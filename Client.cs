using System;
using System.Collections.Generic;
using System.Text;

namespace depInject
{
   public class Client
    {
        private IRepo _repo;

        public Client(IRepo repo)
        {
            this._repo = repo;
        }

        public string GetUsernames()
        {
            return this._repo.GetUser();
        }

    }
}
