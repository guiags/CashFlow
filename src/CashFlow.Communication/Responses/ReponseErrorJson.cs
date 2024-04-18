namespace CashFlow.Communication.Responses;

public class ReponseErrorJson
{
    public string ErrorMessage {  get; set; } = string.Empty;// Required torna obrigatorio o preenchimento na declaração

    public ReponseErrorJson(string errorMessage)//Construtor da classe
    {
        ErrorMessage = errorMessage;
    }
}
