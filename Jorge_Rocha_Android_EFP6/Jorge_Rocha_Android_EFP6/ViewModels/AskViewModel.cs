using Jorge_Rocha_Android_EFP6.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jorge_Rocha_Android_EFP6.ViewModels
{
    internal class AskViewModel: BaseViewModel
    {
        Ask MyAsk { get; set; }
        public AskViewModel() {
        MyAsk = new Ask();
        }

        public async Task<bool> AddNewAsk(string askDescription,string imageUrl,string askDetail)
        {
            if (IsBusy) return false;
            IsBusy = true;

            try
            {
                MyAsk.Date= DateTime.Now;

                MyAsk.AskDescription= askDescription;

                MyAsk.UserId = 3;

                MyAsk.AskStatusId = 4;

                MyAsk.IsStrike = true;

                MyAsk.ImageUrl = imageUrl;

                MyAsk.AskDetail = askDetail;

                bool R = await MyAsk.AddAsk();

                return R;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}
