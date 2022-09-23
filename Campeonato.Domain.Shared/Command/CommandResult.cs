namespace Campeonato.Domain.Shared.Command;

public class CommandResult
{
    #region Constructors

    public CommandResult() { }

    public CommandResult(string message, bool success, object? data)
    {
        Message = message;
        Success = success;
        Data = data;
    }

    #endregion

    #region Properties

    public string Message { get; set; }
    public bool Success { get; set; }
    public object? Data { get; set; }

    #endregion
}