using System;

namespace Business.Entities
{
    public class Comment
    {
        public int IdComment { get; set; }        
        public int IdColumn { get; set; }        
        public string Quote { get; set; }        
        public string User { get; set; }        
        public DateTime Date { get; set; }        
    }
}
