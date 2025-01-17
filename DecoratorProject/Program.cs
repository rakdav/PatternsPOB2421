﻿//IProcessor transmitter = new Transmitter("12345");
//transmitter.Process();
//Shell hamingCode=new HammingCode(transmitter);
//hamingCode.Process();
//Shell encoder = new Encrypt(transmitter);
//encoder.Process();
//interface IProcessor
//{
//    void Process();
//}
//class Transmitter : IProcessor
//{
//    private string data;
//    public Transmitter(string data)=>this.data = data;
//    public void Process() => Console.WriteLine("Данные " + data + " " +
//        "передаем по каналу");
//}
//abstract class Shell : IProcessor
//{
//    protected IProcessor Processor;
//    protected Shell(IProcessor processor)=>Processor = processor;
//    public virtual void Process()=>Processor.Process();
//}
//class HammingCode : Shell
//{
//    public HammingCode(IProcessor processor) : base(processor) { }
//    public override void Process()
//    {
//        Console.WriteLine("Кодирование методом Хэминга было выполнено!");
//        Processor.Process();
//    }
//}
//class Encrypt : Shell
//{
//    public Encrypt(IProcessor processor) : base(processor){}
//    public override void Process()
//    {
//        Console.WriteLine("Данные зашифрованы");
//        Processor.Process();
//    }
//}
IBaby baby = new Child("Вася");
baby.DoSome();
Make say = new Speek(baby);
say.DoSome();
Make work = new Work(baby);
work.DoSome();


interface IBaby
{
    void DoSome();
}
class Child : IBaby
{
    private string name;
    public Child(string data) => this.name = data;
    public void DoSome() => Console.WriteLine("Ребенок " + name + " родился");
}
abstract class Make : IBaby
{
    protected IBaby baby;
    protected Make(IBaby b) =>  baby= b;
    public virtual void DoSome() => baby.DoSome();
}
class Speek : Make
{
    public Speek(IBaby baby) : base(baby) { }
    public override void DoSome()
    {
        Console.WriteLine("Научился говорить!");
        baby.DoSome();
    }
}
class Work : Make
{
    public Work(IBaby baby) : base(baby) { }
    public override void DoSome()
    {
        Console.WriteLine("Научился ходить!");
        baby.DoSome();
    }
}
