using Campeonato.Domain.Commands;
using Campeonato.Domain.Entities.Team;
using Campeonato.Domain.Entities.Team.Repository;
using Campeonato.Domain.Handlers;
using Campeonato.Domain.Shared.Command;
using Campeonato.Domain.Shared.Handler.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Campeonato.Domain.Api.Controllers.Campeonato;

[Route("v1")]
public class TeamController : ControllerBase
{
    #region Privates

    private readonly IRepositoryTeam _repositoryTeam;

    #endregion

    #region Constructors

    public TeamController(IRepositoryTeam repositoryTeam)
    {
        _repositoryTeam = repositoryTeam;
    }

    #endregion

    #region Methods

    [HttpGet]
    [Route("teams")]
    public async Task<IActionResult> Get()
    {
        try
        {
            return Ok(await _repositoryTeam.GetAllTeams());
        }
        catch (Exception e)
        {
            return BadRequest(new CommandResult(e.Message, false, null));
        }
    }

    [HttpPost]
    [Route("teams")]
    public async Task<IActionResult> Post([FromBody] CreateTeamCommand body
        , [FromServices]TeamHandler handler)
    {
        try
        {
            var result = handler.Handle(body);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(new CommandResult(e.Message, false, body));
        }
    }

    #endregion
}