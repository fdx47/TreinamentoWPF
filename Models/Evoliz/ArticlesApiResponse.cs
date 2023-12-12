
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TreinamentoWPF.Models.Evoliz;

public class ArticlesApiResponse
{
    public List<Article> Data { get; set; }
    public Links Links { get; set; }
    public Meta Meta { get; set; }
}

public class Links
{
    [Column(TypeName = ("varchar(100)"))]
    public string First { get; set; }
    [Column(TypeName = ("varchar(100)"))]
    public string Last { get; set; }
    [Column(TypeName = ("varchar(100)"))]
    public string Prev { get; set; }
    [Column(TypeName = ("varchar(100)"))]
    public string Next { get; set; }
}

public class Meta
{
    [JsonPropertyName("current_page")]
    [MaxLength(5)]
    public int CurrentPage { get; set; }

    [JsonPropertyName("from")]
    [MaxLength(20)]
    public int From { get; set; }

    [JsonPropertyName("last_page")]
    [MaxLength(5)]
    public int LastPage { get; set; }
    [Column(TypeName = ("varchar(180)"))]
    public string Path { get; set; }

    [JsonPropertyName("per_page")]
    [MaxLength(5)]
    public int PerPage { get; set; }
    [MaxLength(20)]
    public int To { get; set; }
    [MaxLength(5)]
    public int Total { get; set; }
}
