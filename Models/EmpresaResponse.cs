namespace DRR_PAGE_BLAZOR.Models
{
    public class EmpresaResponse
    {
        public string Status { get; set; } = string.Empty;
        public List<Empresa> Data { get; set; } = new();
    }
}