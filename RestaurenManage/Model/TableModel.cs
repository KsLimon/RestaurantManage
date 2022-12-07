using System.ComponentModel.DataAnnotations;

namespace RestaurenManage.Model
{
    public class TableModel
    {
        [Key]
        public int TabId { get; set; }
        [Required]
        public string TabName { get; set; }
        public string Position { get; set; }
    }
}
