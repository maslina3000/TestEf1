using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class AnswerRepository
    {
        private static AnswerRepository repository = new AnswerRepository();
        private List<AnswerForm> responses = new List<AnswerForm>();
        private static AnswerRepository GetRepository()
        {
            return repository;
        }
        public IEnumerable<AnswerForm> GetAllResponses()
        {
            return responses;
        }
     /*   public void AddResponse(AnswerForm response)
        {
            response.Add(response);
        }
*/
    }
}