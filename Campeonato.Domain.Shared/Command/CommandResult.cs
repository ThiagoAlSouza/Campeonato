namespace Campeonato.Domain.Shared.Command;

public class CommandResult
{
    #region Constructors

    public CommandResult() { }

    public CommandResult(bool success, string message, object? data)
    {
        Success = success;
        Message = message;
        Data = data;
    }

    #endregion

    #region Properties

    public bool Success { get; set; }
    public string Message { get; set; }
    public object? Data { get; set; }

    #endregion
}