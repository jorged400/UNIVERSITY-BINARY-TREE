using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeUniversity
{
    class UniversityTree
    {
        public PositionNode Root;

        public void CreatePosition(PositionNode Parent, Position positionTocreate, string parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionTocreate;

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            if (Parent == null)
            {
                return;
            }
            if (Parent.Position.Name == parentPositionName)
            {
                if (Parent.Left == null)
                {
                    Parent.Left = newNode;
                    return;

                }

                Parent.Right = newNode;
                return;
            }
                CreatePosition(Parent.Left, positionTocreate, parentPositionName);
                CreatePosition(Parent.Right, positionTocreate, parentPositionName);
            }
            public void PrintTree(PositionNode from)
            {
                if ( from == null)
                {
                    return;
                }

                Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}");
                PrintTree(from.Left);
                PrintTree(from.Right);
            }
            
            public float AddSalaries(PositionNode from)
            {
                if (from == null)
                {
                return 0;
                }

            return from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Right);            }
        }
    }

