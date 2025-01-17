Console.Write("Введите массу:");
float kg=float.Parse(Console.ReadLine()!);
float lb = kg;
IScales rScales= new RussianScales(kg);
IScales bScales = new AdapterForBritishScales(new BritishScales(lb));
Console.WriteLine(rScales.GetWeight());
Console.WriteLine(bScales.GetWeight());
interface IScales
{
    float GetWeight();
}
class RussianScales : IScales
{
    private float currentWeight;
    public RussianScales(float cw)=>currentWeight=cw;
    public float GetWeight()=>currentWeight;
}

class BritishScales : IScales
{
    private float currentWeight;
    public BritishScales(float cw) => currentWeight = cw;
    public float GetWeight() => currentWeight;
}

class AdapterForBritishScales : IScales
{
    private BritishScales britishScales;
    public AdapterForBritishScales(BritishScales britishScales)
    {
        this.britishScales = britishScales;
    }
    public float GetWeight()=>britishScales.GetWeight()*0.456f;
}
