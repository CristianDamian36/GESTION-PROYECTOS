using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestiónDeProyectos.Areas.Users.Models;
using GestiónDeProyectos.Library;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestiónDeProyectos.Areas.Users.Pages.Account
{
    public class RegisterModel : PageModel
    {

        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private LUsersRoles _usersRole;
        private static InputModel _dataInput;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _usersRole = new LUsersRoles();
        }

        public void OnGet()
        {
            if (_dataInput != null)
            {
                Input = _dataInput;
                Input.rolesLista = _usersRole.getRoles(_roleManager);
            }
            else
            {
                Input = new InputModel
                {
                    rolesLista = _usersRole.getRoles(_roleManager)
                };
            }

        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel : InputModelRegister
        {
            public string ErrorMessage { get; set; }
            public List<SelectListItem> rolesLista { get; set; }
        }

        public async Task<IActionResult> OnPost()
        {
            if (await SaveAsync())
            {
                return Redirect("/Users/Users?area=Users");
            }
            else
            {
                return Redirect("/User/Register");
            }
        }



        private async Task<bool> SaveAsync()
        {
            _dataInput = Input;
            var valor = false;

            return valor;
        }
    }
}
