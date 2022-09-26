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
    private readonly TeamHandler _teamHandler;

    #endregion

    #region Constructors

    public TeamController(IRepositoryTeam repositoryTeam, TeamHandler teamHandler)
    {
        _repositoryTeam = repositoryTeam;
        _teamHandler = teamHandler;
    }

    #endregion

    #region Methods

    [HttpGet]
    [Route("teams")]
    public async Task<IActionResult> Get()
    {
        try
        {
            return Ok(new CommandResult(true, string.Empty, await _repositoryTeam.GetAllTeams()));
        }
        catch (Exception e)
        {
            return BadRequest(new CommandResult(false, e.Message, null));
        }
    }

    [HttpPost]
    [Route("teams")]
    public async Task<IActionResult> Post([FromBody] CreateTeamCommand body)
    {
        try
        {
            var result = _teamHandler.Handle(body);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(new CommandResult(false, e.Message, body));
        }
    }

    #endregion
}