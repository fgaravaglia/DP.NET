using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public enum Levels {Manager, Supervisor, Clerk}
    
    public class Structure
    {
        public int Limit { get; set; }
        public int Positions { get; set; }
    }

    public class Handler
    {
        static Random choice = new Random(11);
        /// <summary>
        /// primo elemento della gerarchia
        /// </summary>
        private Levels First
        {
            get { return ((Levels[])Enum.GetValues(typeof(Levels)))[0]; }
        }
        /// <summary>
        /// strutturadella banca; assegnal limiti e gerarchia
        /// </summary>
        private Dictionary<Levels, Structure> structure = new Dictionary<Levels, Structure>();
        /// <summary>
        /// per ogni livello, assegno gli handler registrati
        /// </summary>
        private Dictionary<Levels, List<Handler>> handlersAtLevel = new Dictionary<Levels, List<Handler>>();     
        private Levels level;
        private int id;

        public Handler(int id, Levels level, Dictionary<Levels, Structure> mySruct, Dictionary<Levels, List<Handler>> handlers)
        {
            this.id = id;
            this.level = level;
            structure = mySruct;
            handlersAtLevel = handlers;
        }

        public string HandleRequest(int data)
        {
            if (data < structure[level].Limit)
            {
                return "Request for " + data + " handled by " + level + " " + id;
            }
            else if (level > First)
            {
                Levels nextLevel = --level;
                int which = choice.Next(structure[nextLevel].Positions);
                return handlersAtLevel[nextLevel][which].HandleRequest(data);
            }
            else
            {
                Exception chainException = new ChainException();
                chainException.Data.Add("Limit", data);
                throw chainException;
            }
        }
        //Handler next;
        //int id;

        //public int Limit { get; set; }
        
        //public Handler(int id, Handler handler)
        //{
        //    this.id = id;
        //    Limit = id * 1000;
        //    next = handler;
        //}
        
        //public string HandleRequest(int data)
        //{
        //    if (data < Limit)
        //        return "Request for " + data + " handled at level " + id;
        //    else if (next != null)
        //        return next.HandleRequest(data);
        //    else return ("Request for " + data + " handled BY DEFAULT at level " + id);
        //}
    }
}
