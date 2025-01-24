using GenericsWthConstraints.Generic_Example;

namespace GenericsWthConstraints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////where T: IComparable
            ////IComparable implementation although it comes under Interface constraint:
            ////Here we are fining maximuum number between 2 numbers.
            //ComparableInterfaceConstraint CS = new ComparableInterfaceConstraint();
            //CS.Comparable_Interfaces();

            ////where T: <base class>
            //BaseClassConstraint BCC = new BaseClassConstraint();
            //BCC.BaseClass();

            ////where T: struct
            //StructConstraint sc = new StructConstraint();
            //sc.nullable();

            ////where T: class
            //ClassConstraint CC = new ClassConstraint();
            //CC.ClassObject();

            ////where T: new()
            //NewConstraint nw = new NewConstraint();
            //nw.ParameterlessInstance();

            //Implementation of generics
            GenericImplementation GI = new GenericImplementation();
            GI.implementation();
        }
    }
}
