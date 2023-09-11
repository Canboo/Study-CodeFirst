using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api.Models;

public class User
{
    /// <summary>
    /// 使用者系統識別碼
    /// </summary>
    [Comment("使用者系統識別碼")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// 使用者名稱
    /// </summary>
    [Required]
    [Comment("使用者名稱")]
    [Column(TypeName = "nvarchar(50)")]
    public string UserName { get; set; }

    [Required]
    [Comment("註冊時間")]
    public DateTime RegTime { get; set; } = DateTime.Now;

    [Comment("資料修改時間")]
    public DateTime? ModifyTime { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    [Required]
    [Comment("備註")]
    [Column(TypeName = "nvarchar(50)")]
    public string Memo { get; set; } = "內容測試";

    public ICollection<Post> Posts { get; set; }
}