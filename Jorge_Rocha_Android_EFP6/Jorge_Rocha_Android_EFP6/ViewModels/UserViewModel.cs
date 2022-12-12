using Jorge_Rocha_Android_EFP6.Models;
using Jorge_Rocha_Android_EFP6.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jorge_Rocha_Android_EFP6.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public User MyUser { get; set; }
        public UserDTO MyUserDTO { get; set; }

        public UserViewModel() {
            MyUser = new User();
            MyUserDTO = new UserDTO();
        }

        public async Task<UserDTO> getUserData(int userId)
        {

            try
            {
                UserDTO user = new UserDTO();

                user = await MyUserDTO.getUserData(userId);

                if (user == null) { return null; } else { return user; }
            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}
