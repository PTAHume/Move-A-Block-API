namespace Move_A_Block_API;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BlockTypes : short
{
    [EnumMember(Value = "Blank")]
    Blank = 0,

    [EnumMember(Value = "Player")]
    Player = 1,

    [EnumMember(Value = "Box")]
    Box = 2,

    [EnumMember(Value = "Goal")]
    Goal = 3,

    [EnumMember(Value = "Invalid")]
    Invalid = 4,

    [EnumMember(Value = "Obstacle")]
    Obstacle = 5
}