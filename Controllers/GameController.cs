namespace Move_A_Block_API.Controllers;

using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class GameController : ControllerBase
{
    [HttpGet(template: "{levelNumber:int}", Name = "GetLevel")]
    [EnableCors(policyName: "AllowOrigin")]
    public IEnumerable<Cell> GetLevel(int levelNumber)
    {
        return levelNumber switch
        {
            0 => new List<Cell>()
                    {
                        new() { Content = BlockTypes.Player , Index = 10},
                        new() { Content = BlockTypes.Box , Index = 17 },
                        new() { Content = BlockTypes.Goal, Index = 77 },
                        new() { Content = BlockTypes.Obstacle, Index = 35 },
                    },
            1 => new List<Cell>()
                    {
                        new() { Content = BlockTypes.Player , Index = 10 },
                        new() { Content = BlockTypes.Box , Index = 17 },
                        new() { Content = BlockTypes.Goal, Index = 27 },
                        new() { Content = BlockTypes.Obstacle, Index = 35  },
                        new() { Content = BlockTypes.Box , Index = 47},
                        new() { Content = BlockTypes.Goal, Index = 52 },
                        new() { Content = BlockTypes.Obstacle, Index = 55  }
                    },
            _ => new List<Cell>()
                    {
                        new() { Content = BlockTypes.Player , Index = 10 },
                        new() { Content = BlockTypes.Box , Index = 17 },
                        new() { Content = BlockTypes.Goal, Index = 27 },
                        new() { Content = BlockTypes.Obstacle, Index = 35  },
                        new() { Content = BlockTypes.Box , Index = 47},
                        new() { Content = BlockTypes.Goal, Index = 52 },
                        new() { Content = BlockTypes.Obstacle, Index = 55  }
                    },
        };
    }
}