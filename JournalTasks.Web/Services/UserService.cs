using JournalTasks.Web.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace JournalTasks.Web.Services;

public class UserService : IUserService
{
    private readonly AuthenticationStateProvider _authenticationStateProvider;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly NavigationManager _navigationManager;

    public UserService(
        AuthenticationStateProvider authenticationStateProvider,
        UserManager<ApplicationUser> userManager,
        NavigationManager navigationManager)
    {
        _authenticationStateProvider = authenticationStateProvider;
        _userManager = userManager;
        _navigationManager = navigationManager;
    }

    public async Task<string?> GetUserIdAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity != null && user.Identity.IsAuthenticated)
        {
            var appUser = await _userManager.GetUserAsync(user);
            return appUser?.Id;
        }
 
        _navigationManager.NavigateTo("/Account/Login", true);
        return null;
    }
}