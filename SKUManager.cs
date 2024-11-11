using System;
using System.Collections.Generic;
using System.Linq;

public class SKUManager
{
    private readonly List<string> _skuList;
    private readonly List<string> _highEndGpus = new List<string> { "3060", "3070", "3080", "3090", "40" };

    public SKUManager(List<string> skuList)
    {
        _skuList = skuList;
    }

    public bool HasHighEndGpu(string sku)
    {
        Console.WriteLine($"[DEBUG] Checking SKU: {sku}");

        foreach (var gpu in _highEndGpus)
        {
            Console.WriteLine($"[DEBUG] GPU Identifier: {gpu}");
            if (sku.IndexOf(gpu, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"[DEBUG] Found GPU: {gpu} in SKU: {sku}");
                return true;
            }
        }

        Console.WriteLine($"[DEBUG] No high-end GPU found in SKU: {sku}");
        return false;
    }

}
