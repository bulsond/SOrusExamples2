using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    /// <summary>
    /// Для заполнения комбобоксов
    /// </summary>
    class ComboItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }

    public partial class FormMain : Form
    {
        private const string _conString = @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=RoomsDB;Integrated Security=True;" +
            "Connect Timeout=60;Encrypt=False;" +
            "TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //источник данных для комбобокса типов комнат
        private BindingSource _bsTypes;
        //источник данных для комбобокса комнат
        private BindingSource _bsNumbers;

        public FormMain()
        {
            InitializeComponent();

            //привязка к комбобоксу выбора тип комнат
            _bsTypes = new BindingSource();
            _bsTypes.DataSource = typeof(ComboItem);
            _comboBoxTypes.DataSource = _bsTypes;
            _comboBoxTypes.DisplayMember = nameof(ComboItem.Text);

            //привязка к комбобоксу выбора номеров комнат
            _bsNumbers = new BindingSource();
            _bsNumbers.DataSource = typeof(ComboItem);
            _comboBoxNumbers.DataSource = _bsNumbers;
            _comboBoxNumbers.DisplayMember = nameof(ComboItem.Text);

            this.Load += FormMain_Load;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            _bsTypes.Add(new ComboItem { Text = "Любой" });
            _bsNumbers.Add(new ComboItem { Text = "Нет выбора" });

            //извлекаем из БД типы комнат, заполняем комбобокс
            await LoadRoomTypesAsync();
            //подписка на событие выбора типа комнаты
            _bsTypes.CurrentChanged += OnRoomTypeSelected;
        }

        /// <summary>
        /// После выбора типа комнат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnRoomTypeSelected(object sender, EventArgs e)
        {
            //определяем Id выбранного пункта
            int selectedId = (_bsTypes.Current as ComboItem).Id;
            //очищаем комбобокс
            _bsNumbers.Clear();

            //в случае выбора "Любой"
            if (selectedId == 0)
            {
                _bsNumbers.Add(new ComboItem { Text = "Нет выбора" });
                return;
            }

            await LoadRoomNumbersByTypeIdAsync(selectedId);
        }

        /// <summary>
        /// Заполение комбобкса типов комнат
        /// </summary>
        /// <returns></returns>
        private async Task LoadRoomTypesAsync()
        {
            try
            {
                using (var con = new SqlConnection(_conString))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"SELECT Id
                                     , Name
                                    FROM RoomTypes
                                    ORDER BY Name;";
                    await con.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var ci = new ComboItem
                            {
                                Id = reader.GetInt32(0),
                                Text = reader.GetString(1)
                            };
                            _bsTypes.Add(ci);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Заполнение комбобокса номерами комнат нужного типа
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        private async Task LoadRoomNumbersByTypeIdAsync(int typeId)
        {
            try
            {
                using (var con = new SqlConnection(_conString))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"SELECT r.Id, r.Number
                                        FROM dbo.Rooms AS r
                                        INNER JOIN dbo.RoomTypes AS t
	                                        ON r.RoomTypeId = t.Id
                                        WHERE ReservationId = 0 AND t.Id = @id
                                        ORDER BY Number;";

                    var param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = typeId;
                    cmd.Parameters.Add(param);

                    await con.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        //если есть свободные комнаты данного типа
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                var ci = new ComboItem
                                {
                                    Id = reader.GetInt32(0),
                                    Text = reader.GetInt32(1).ToString()
                                };
                                _bsNumbers.Add(ci);
                            }
                        }
                        else
                        {
                            //иначе нет свободных комнат
                            _bsNumbers.Add(new ComboItem { Text = "Нет свободных" });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
