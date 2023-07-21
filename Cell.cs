namespace Move_A_Block_API;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Cell
{
    [Required]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public BlockTypes Content { get; set; } = 0;

    [Required]
    public int Index { get; set; } = 0;
}
