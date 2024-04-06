using System.ComponentModel.DataAnnotations;

namespace DA_Xuong.Models
{
    public class TACGIA
    {
        [Key]
        public int IDTACGIA { get; set; }
        public string TENTACGIA { get; set; }
        public string TIEUSU {  get; set; }

        public ICollection<SACH> SACH {  get; set; }
    }
}
