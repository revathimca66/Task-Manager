using Capsule_TaskManagerBL;
using Capsule_TaskManagerDL.Model;
using System.Collections.Generic;
using System.Web.Http;

namespace Capsule_TaskManager.Controllers
{
    public class TaskManagerController : ApiController
    {
        #region Public Declaration

        TaskManagerBL objTaskManagerBL = null;

        #endregion

        #region GetParentTask
        [Route("api/TaskManager/GetParentTask")]
        [HttpGet]       
        public IEnumerable<GET_PARENT_TASK_Result> GetParentTask()
        {
            objTaskManagerBL = new TaskManagerBL();
            var vGetparentTaskDetails = objTaskManagerBL.GetParentTask();

            return vGetparentTaskDetails;
        }
        #endregion

        #region GetTaskDetails
        [Route("api/TaskManager/GetTaskDetails")]
        
        [HttpGet]       
        public IEnumerable<GET_TASK_DETAILS_Result> GetTaskDetails()
        {
            objTaskManagerBL = new TaskManagerBL();
            var vGetTaskDetails = objTaskManagerBL.GetTaskDetails();

            return vGetTaskDetails;
        }
        #endregion

        #region InsertTaskDetails
        [Route("api/TaskManager/InsertTaskDetails")]
        [HttpPost]
        public string InsertTaskDetails(GET_TASK_DETAILS_Result objGET_TASK_DETAILS_Result)
        {
            objTaskManagerBL = new TaskManagerBL();
            var vInsertTaskDetails = objTaskManagerBL.InsertTaskDetails(objGET_TASK_DETAILS_Result);
            return vInsertTaskDetails;
        }
        #endregion

        #region UpdateEndTask
        [Route("api/TaskManager/UpdateEndTask")]
        [HttpPost]
        public string UpdateEndTask(GET_TASK_DETAILS_Result objGET_TASK_DETAILS_Result)
        {
            objTaskManagerBL = new TaskManagerBL();
            var vUpdateEndTask = objTaskManagerBL.UpdateEndTask(objGET_TASK_DETAILS_Result);

            return vUpdateEndTask;
        }
        #endregion 
    }
}
