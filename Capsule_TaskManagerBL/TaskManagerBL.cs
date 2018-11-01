using Capsule_TaskManagerDL;
using Capsule_TaskManagerDL.Model;
using System;
using System.Collections.Generic;

namespace Capsule_TaskManagerBL
{
    public class TaskManagerBL
    {
        #region Public Declaration

        TaskManagerDL objTaskManagerDL = null;

        #endregion

        #region GetParentTask

        public IEnumerable<GET_PARENT_TASK_Result> GetParentTask()
        {
            objTaskManagerDL = new TaskManagerDL();
            var vGetparentTaskDetails = objTaskManagerDL.GetParentTask();

            return vGetparentTaskDetails;
        }
        #endregion 
        
        #region GetTaskDetails

        public IEnumerable<GET_TASK_DETAILS_Result> GetTaskDetails()
        {
            objTaskManagerDL = new TaskManagerDL();
            var vGetTaskDetails = objTaskManagerDL.GetTaskDetails();

            return vGetTaskDetails;
        }
        #endregion 

        #region InsertTaskDetails

        public string InsertTaskDetails(GET_TASK_DETAILS_Result objGET_TASK_DETAILS_Result)
        {
            objTaskManagerDL = new TaskManagerDL();
            var vInsertTaskDetails = objTaskManagerDL.InsertTaskDetails(objGET_TASK_DETAILS_Result);

            return vInsertTaskDetails;
        }
        #endregion

        #region UpdateEndTask

        public string UpdateEndTask(GET_TASK_DETAILS_Result objGET_TASK_DETAILS_Result)
        {
            objTaskManagerDL = new TaskManagerDL();
            var vUpdateEndTask = objTaskManagerDL.UpdateEndTask(objGET_TASK_DETAILS_Result);

            return Convert.ToString(vUpdateEndTask);
        }
        #endregion 

    }
}
