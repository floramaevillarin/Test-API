using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Repository
{
    public interface IStateReporistory
    {
        IList<State> GetState();
        State GetState(string stateId);
        void Add(State state);
        State Update(State state);
        void Delete(State state);
    }
}
