interface ISite
{
    string GetPage(int num);
}
class Site : ISite
{
    public string GetPage(int num) => "page " + num;
}
class SiteProxy : ISite
{
    private ISite site;
    private Dictionary<int, string> cache;
    public SiteProxy(ISite size)
    {
        this.site = size;
        cache = new Dictionary<int, string>();
    }
    public string GetPage(int num)
    {
        string page;
        if (cache.ContainsKey(num))
        {
            page = cache[num];
            page = "from cache " + page;
        }
        else
        {
            page=site.GetPage(num);
            cache.Add(num, page);
        }
        return page;
    }
}
