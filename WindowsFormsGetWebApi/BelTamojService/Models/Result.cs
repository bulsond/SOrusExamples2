namespace BelTamojService.Models
{
    public class Result
    {
        public int id { get; set; }
        public int place_id { get; set; }
        public string updated { get; set; }
        public string declType { get; set; }
        public string declMode { get; set; }
        public string declOwner { get; set; }
        public string regNumber { get; set; }
        public string regDate { get; set; }
        public string accNumber { get; set; }
        public string accDate { get; set; }
        public string requirementText { get; set; }
        public string requirementDate { get; set; }
        public string refusalReason { get; set; }
        public string referenceNumber { get; set; }
        public int declStatus { get; set; }
        public string wrkPoint { get; set; }
    }
}
