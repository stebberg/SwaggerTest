using System.Runtime.Serialization;

namespace SwaggerTest
{
    [KnownType(typeof(AccountNotFound))]
    [KnownType(typeof(AccountClosed))]
    public abstract class Err
    {

        public abstract int Code { get; }
        public abstract string Title { get; }
    }

    public class AccountNotFound : Err
    {
        public override int Code { get => 100; }
        public override string Title { get => "Konto finns ej"; }
    }

    public class AccountClosed : Err
    {
        public override int Code { get => 200; }
        public override string Title { get => "Konto är stängt"; }
    }
}
