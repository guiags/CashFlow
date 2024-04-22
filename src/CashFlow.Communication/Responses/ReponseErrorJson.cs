namespace CashFlow.Communication.Responses;

public class ReponseErrorJson
{
    public List<string> ErrorMessage {  get; set; }// Required torna obrigatorio o preenchimento na declaração

    public ReponseErrorJson(string errorMessage)//Construtor da classe
    {
        ErrorMessage = [errorMessage];
    }
    public ReponseErrorJson(List<string> errorMessage)
    {
        ErrorMessage = errorMessage;
    }
}
