using CyberStore.Data;
using CyberStore.Models;

namespace CyberStore.Database;

public static class ProductCreator
{
    public static List<Product> Products = new()
    {
        new Product()
        {
            Id = new Guid("5745a8ec-35b7-40d9-abf5-f5674407d2b2"),
            Name = "Intel Core i7-13700KF Gaming Desktop Processor 16 cores (8 P-cores + 8 E-cores) - Unlocked",
            Description = 
@"13th Gen Intel Core processors offer revolutionary design for beyond real-world performance. From extreme multitasking, immersive streaming, and faster creating, do what you do.Max Memory Bandwidth : 89.6 GB/s. Instruction Set : 64-bit.
16 cores (8 P-cores + 8 E-cores) and 24 threads
Up to 5.4 GHz unlocked. 30M Cache
Discrete graphics required
Compatible with Intel 600 series (might need BIOS update) and 700 series chipset-based motherboards
Performance hybrid architecture integrates two core microarchitectures, prioritizing and distributing workloads to optimize performance
Turbo Boost Max Technology 3.0, and PCIe 5.0 & 4.0 support. Intel Optane Memory support. No thermal solution included
",
           Price = 379.99f,
            Category = "Processor",
            Image = "https://m.media-amazon.com/images/I/61IUbGdPo6L._AC_SX679_.jpg",
            SKU = "B0BCDL7F5W",
            Brand = "Intel",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("93e17931-2e03-4ce1-be11-772facc30303"),
            Name = "Intel Core i5-13600K Desktop Processor 14 cores (6 P-cores + 8 E-cores) with Integrated Graphics - Unlocked",
            Description = 
@"13th Gen Intel Core processors offer revolutionary design for beyond real-world performance. From extreme multitasking, immersive streaming, and faster creating, do what you do
14 cores (6 P-cores + 8 E-cores) and 20 threads
Up to 5.1 GHz unlocked. 24M Cache
Integrated Intel UHD Graphics 770 included
Compatible with Intel 600 series (might need BIOS update) and 700 series chipset-based motherboards
Performance hybrid architecture integrates two core microarchitectures, prioritizing and distributing workloads to optimize performance
Turbo Boost Max Technology 3.0, and PCIe 5.0 & 4.0 support. Intel Optane Memory support. No thermal solution included
",
            Price = 317.99f,
            Category = "Processor",
            Image = "https://m.media-amazon.com/images/I/61lNEpDfdcL._AC_SX679_.jpg",
            SKU = "B0BCDR9M33",
            Brand = "Intel",
            IsAvailable = false
        },
        new Product()
        {
            Id = new Guid("5b07beba-b41c-4f61-94a4-240a6cf949ec"),
            Name = "Intel Core i9-13900KF Gaming Desktop Processor 24 cores (8 P-cores + 16 E-cores) - Unlocked",
            Description = 
@"Stream, create, and compete at the highest levels with industry leading features and the latest hybrid architecture
24 cores (8 P-cores + 16 E-cores) and 32 threads
Up to 5.8 GHz unlocked. 36M Cache
Discrete graphics required
Compatible with Intel 600 series (might need BIOS update) and 700 series chipset-based motherboards
Performance hybrid architecture integrates two core microarchitectures, prioritizing and distributing workloads to optimize performance
Turbo Boost Max Technology 3.0, and PCIe 5.0 & 4.0 support. Intel Optane Memory support. No thermal solution included
",
            Price = 544.99f,
            Category = "Processor",
            Image = "https://m.media-amazon.com/images/I/61-+pgXU1vL._AC_SX679_.jpg",
            SKU = "B0BCFM3CJ4",
            Brand = "Intel",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("22272043-bbfd-4d92-986a-c27f615ad8ba"),
            Name = "AMD Ryzen™ 5 4600G, 6-Core, 12-Thread Unlocked Desktop Processor with Wraith Stealth Cooler",
            Description = 
@"Features powerful graphics performance in a desktop processor for smooth 1080p gaming, no graphics card required
6 Cores and 12 processing threads, bundled with the AMD Wraith Stealth cooler
4.2 GHz Max Boost, unlocked for overclocking, 11 MB cache, DDR4-3200 support
For the advanced Socket AM4 platform",
            Price = 98f,
            Category = "Processor",
            Image = "https://m.media-amazon.com/images/I/61xqmYOrStL._AC_SX679_.jpg",
            SKU = "B09Z5NH6SJ",
            Brand = "AMD",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("79974d06-555d-4cce-9699-25793d31db49"),
            Name = "AMD Ryzen™ 7 5700X 8-Core, 16-Thread Unlocked Desktop Processor",
            Description = 
@"Can deliver ultra-fast 100 plus FPS performance in the world's most popular games, discrete graphics card required
8 Cores and 16 processing threads, based on AMD Zen 3 architecture
4.6 GHz Max Boost, unlocked for overclocking, 36 MB cache, DDR4-3200 support
For the advanced Socket AM4 platform, can support PCIe 4.0 on X570 and B550 motherboards
Cooler not included . Max. Operating Temperature (Tjmax) 90°C",
            Price = 209f,
            Category = "Processor",
            Image = "https://m.media-amazon.com/images/I/61eXyK93hQL._AC_SX679_.jpg",
            SKU = "B09VCHQHZ6",
            Brand = "AMD",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("3b8a7716-d424-4733-90c9-dc715a96fe3c"),
            Name = "AMD Ryzen 9 5900X 12-core, 24-Thread Unlocked Desktop Processor",
            Description = 
@"The world's best gaming desktop processor, with 12 cores and 24 processing threads
Can deliver elite 100-plus FPS performance in the world's most popular games
Cooler not included, high-performance cooler recommended. Max Temperature- 90°C
4.8 GHz Max Boost, unlocked for overclocking, 70 MB of cache, DDR-3200 support
For the advanced Socket AM4 platform, can support PCIe 4.0 on X570 and B550 motherboards",
            Price = 359f,
            Category = "Processor",
            Image = "https://m.media-amazon.com/images/I/616VM20+AzL._AC_SX679_.jpg",
            SKU = "B08164VTWH",
            Brand = "AMD",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("c0ec821a-2042-4f06-a44a-587354f81857"),
            Name = "PNY GeForce RTX™ 4060 Ti 16GB XLR8 Gaming Verto RGB Triple Fan Graphics Card DLSS 3",
            Description = 
@"Powered by NVIDIA DLSS 3, ultra-efficient Ada Lovelace arch, and full ray tracing
NVIDIA Ada Lovelace, with 2310MHz core clock and 2535MHz boost clock speeds to help meet the needs of demanding games.
16GB GDDR6 (128-bit) on-board memory, plus 4352 CUDA processing cores and up to 288GB/sec of memory bandwidth provide the memory needed to create striking visual realism.
PCI Express 4.0 interface - Offers compatibility with a range of systems. Also includes DisplayPort and HDMI outputs for expanded connectivity.
NVIDIA GeForce Experience - Capture and share videos, screenshots, and livestreams with friends. Keep your drivers up to date and optimize your game settings. It's the essential companion to your GeForce graphics card.
PCI-Express 4.0 x16 (x8 Active)",  
            Price = 519.99f,
            Category = "Graphics Coprocessor",
            Image = "https://m.media-amazon.com/images/I/61fCyY4LGzL._AC_SX425_.jpg",
            SKU = "B0CG2N9H4X",
            Brand = "PNY",
            IsAvailable = false
        },
        new Product()
        {
            Id = new Guid("f0fa428b-7353-44ef-84af-eacf9010b2ea"),
            Name = "ASUS TUF Gaming NVIDIA GeForce RTX™ 4070 OC Edition Gaming Graphics Card (PCIe 4.0, 12GB GDDR6X, HDMI 2.1, DisplayPort 1.4a)",
            Description = 
@"Powered by NVIDIA DLSS3, ultra-efficient Ada Lovelace arch, and full ray tracing..Memory Speed : 21 Gbps. Recommended PSU : 750W
4th Generation Tensor Cores: Up to 4x performance with DLSS 3 vs. brute-force rendering
3rd Generation RT Cores: Up to 2X ray tracing performance
OC mode: 2580 MHz (OC mode)/ 2550 MHz (Default mode)
Axial-tech fans scaled up for 21% more airflow
Dual ball fan bearings last up to twice as long as conventional designs
Military-grade capacitors rated for 20K hours at 105C make the GPU power rail more durable",
            Price = 659.99f,
            Category = "Graphics Coprocessor",
            Image = "https://m.media-amazon.com/images/I/81LSzIhifEL._AC_SX679_.jpg",
            SKU = "B0BZTDZL7J",
            Brand = "ASUS",
            IsAvailable = false
        }
    };

    public static void CreateProducts(this IServiceProvider services)
    {
        var scope = services.CreateScope();
        var applicationRepository = (ApplicationRepository)scope.ServiceProvider.GetService(typeof(ApplicationRepository));
        if (applicationRepository is not null)
        {
            foreach (var product in Products)
            {
                if (applicationRepository.Find(typeof(Product), product.Id) is null)
                {
                    applicationRepository.Add(product);
                }
            }
            applicationRepository.SaveChanges();
        }
    }
}