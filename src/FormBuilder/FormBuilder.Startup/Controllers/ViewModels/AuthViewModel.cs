using FormBuilder.UIs;

namespace FormBuilder.Startup.Controllers.ViewModels;

public class AuthViewModel : IStepViewModel
{
    public string Login { get; set; }
    public string ReturnUrl { get; set; }
    public List<ExternalIdProviderViewModel> ExternalIdProviders { get; set; }
    public string StepId { get; set; }
    public string WorkflowId { get; set; }
    public string CurrentLink { get; set; }
}
