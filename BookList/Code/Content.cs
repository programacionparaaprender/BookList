
/*
Content service = new Content();
var contentTask = service.GetContentAsync();
var countTask = service.GetCountAsync();
var nameTask = service.GetNameAsync();
var content = await contentTask;
var count = await countTask;
var name = await nameTask;

using System.Threading.Tasks;

*/



using System.Threading;
using System.Threading.Tasks;

namespace BookList.Models
{
 
public class Content
{
   public Content()
   {

   }

	public async Task<string> GetContentAsync()
	{
		await Task.Delay(2000);
		return "content";
	}
	public async Task<int> GetCountAsync()
	{
		await Task.Delay(5000);
		return 4;
	}
	public async Task<string> GetNameAsync()
	{
		await Task.Delay(3000);
		return "Matthew";
	}
    public string GetContent()
    {
        Thread.Sleep(2000);
        return "content";
    }
    public int GetCount()
    {
        Thread.Sleep(5000);
        return 4;
    }
    public string GetName()
    {
        Thread.Sleep(3000);
        return "Matthew";
    }
}

}
