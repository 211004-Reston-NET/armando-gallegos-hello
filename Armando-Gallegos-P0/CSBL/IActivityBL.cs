using System.Collections.Generic;
using CSModels;
/// <summary>
///
/// </summary>
namespace CSBL 
{
    public interface IActivityBL
    {
        /// <summary>
        /// This returns the lists stored in the JSON's
        /// </summary>
        /// <returns></returns>
        List<Activity> GetAllActivities();

        Activity AddActivity(Activity p_act);

    }
}