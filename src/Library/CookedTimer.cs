using System;
using System.Threading;

namespace Full_GRASP_And_SOLID;

public class CookedTimer : TimerClient
{
    public Recipe Recipe {get; set;}

    public CookedTimer(Recipe recipe)
    {
        this.Recipe = recipe;
    }
    public void TimeOut()
    {
        this.Recipe.SetCooked();
    }
}