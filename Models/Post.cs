using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api.Models;

/// <summary>
/// 貼文
/// </summary>
public partial class Post
{
    [Comment("貼文系統識別碼")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// 使用者系統識別碼
    /// </summary>
    [Comment("使用者系統識別碼")]
    public int UserId { get; set; }

    /// <summary>
    /// 標題
    /// </summary>
    [Required]
    [Comment("標題")]
    [Column(TypeName = "nvarchar(200)")]
    public string Title { get; set; }

    [Required]
    [Comment("內容")]
    [Column(TypeName = "nvarchar(MAX)")]
    public string Content { get; set; } = string.Empty;

    [Comment("是否已讀")]
    public int Read { get; set; } = 0;

    [Required]
    [Comment("張貼時間")]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime PostTime { get; set; } = DateTime.Now;

    public virtual User User { get; set; }
}