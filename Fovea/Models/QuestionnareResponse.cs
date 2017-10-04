using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fovea.Models
{
    public class QuestionnareResponse
    {
        public int Id { get; set; }
        public string Response { get; set; }
        //Foreign key
        public int QuestionnareId {get; set;}
        public int QuestionId { get; set; }

        public Questionnare Questionnare { get; set; }
        public Question Question { get; set; }
    }
}