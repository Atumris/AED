﻿/*
=================================================================================	
  
               Vak:	AD


	Gemaakt door: 	Robbie Roeten, Henri Arends, Mirek Nalepa, Patrick Niewold
			        Joey Pieters


	    Docenten:	Jeroen Pijpker, Rob Smit

=================================================================================
 */
using System;

namespace MainDLL.Search
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data;
        public Node<T> Left;
        public Node<T> Right;

        public int Parse(T value)
        {
            return Int32.Parse(value.ToString());
        }
        
        /// <summary>
        /// Display Node Data
        /// </summary>
        public void DisplayNode()
        {
            //Console.Write(Data + " ");
        }
    }
}
