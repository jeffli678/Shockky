﻿namespace Shockky.Lingo.Bytecode.Instructions
{
    public class NotEqualIns : Computation
    {
        public NotEqualIns() //<>
            : base(OPCode.NotEqual)
        { }

        protected override object Execute(dynamic left, dynamic right)
        {
            return (left != right);
        }
    }
}