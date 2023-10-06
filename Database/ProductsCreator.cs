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
        },
        new Product()
        {
            Id = new Guid("ca170529-fdab-4fcf-8e84-dd6e20f6767a"),
            Name = "Corsair VENGEANCE RGB PRO DDR4 32GB (2x16GB) 3200MHz CL16 Intel XMP 2.0 iCUE Compatible Computer Memory - Black (CMW32GX4M2E3200C16)",
            Description = 
@"Dynamic Multi-Zone RGB Lighting: 10 Ultra-bright RGB LEDs per module.
Take control in CORSAIR iCUE software and synchronize lighting with other CORSAIR RGB products, including CPU coolers, keyboards and fans.
Custom Performance PCB provides the highest signal quality for the greatest level of performance and stability.
Tightly Screened Memory: Carefully screened ICs for extended overclocking potential.
Maximum Bandwidth and Tight Response Times Optimized for peak performance on the latest Intel and AMD DDR4 motherboards.
Requires no extra wires or cables for a clean and seamless install.
Supports XMP 2.0: A single BIOS setting is all that’s required to set your memory to its ideal performance settings, for for optimum performance.
SPD Latency: 15-15-15-36",
            Price = 77.99f,
            Category = "Computer Memory",
            Image = "https://m.media-amazon.com/images/I/71e6YWJio-L._AC_SX679_.jpg",
            SKU = "B081XWLQKS",
            Brand = "Corsair",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("adfa7157-51db-40bf-a868-f9cd082cc10d"),
            Name = "Corsair VENGEANCE RGB PRO SL DDR4 32GB (2x16GB) 3600MHz CL18 Intel XMP 2.0 AMD Ryzen iCUE Compatible Computer Memory - White (CMH32GX4M2D3600C18W)",
            Description = 
@"Illuminate your system with vivid, animated lighting from ten individually addressable, ultra-bright RGB LEDs per module.
Choose from dozens of preset lighting profiles, or create your own in CORSAIR iCUE software.
Just 44mm tall for wide compatibility with air coolers such as the CORSAIR A500.
Optimized for maximum bandwidth and tight response times on the latest Intel and AMD DDR4 motherboards.
A custom performance PCB provides the highest signal quality for the greatest level of performance and stability.
VENGEANCE RGB PRO SL modules use only tightly screened memory chips, for extended overclocking potential.
Take control with CORSAIR iCUE software and synchronize lighting with other CORSAIR RGB products, including coolers, keyboards and fans.",
            Price = 89.99f,
            Category = "Computer Memory",
            Image = "https://m.media-amazon.com/images/I/61ks5I-TN1L._AC_SX679_.jpg",
            SKU = "B08SQRF8MJ",
            Brand = "Corsair",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("6697659a-01aa-476a-aff3-a733748f3c88"),
            Name = "Crucial RAM 32GB Kit (2x16GB) DDR5 5600MHz (or 5200MHz or 4800MHz) Laptop Memory CT2K16G56C46S5, Black",
            Description = 
@"5600MT/s RAM can downclock if system specification only supports 5200MT/s or 4800MT/s
Best for 13th Gen Intel Core and AMD Ryzen 7000 Series processors
Intel XMP 3.0 and AMD EXPO supported on the same module
Enhance productivity, save time and money, game at higher frame rates, multitask better
ECC Type = Non-ECC, Form Factor = SODIMM, Pin Count = 262-Pin, PC Speed = PC5-44800, Voltage = 1.1V, Rank And Configuration = 1Rx8",
            Price = 83.69f,
            Category = "Computer Memory",
            Image = "https://m.media-amazon.com/images/I/71k-boqf32L._AC_SX679_PIbundle-2,TopRight,0,0_SH20_.jpg",
            SKU = "B0BLTDRRLF",
            Brand = "Crucial",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("bd64f33a-8cb2-495d-bc0e-47859e8c87dd"),
            Name = "Asus ROG Strix B550-F Gaming WiFi II AMD AM4 (3rd Gen Ryzen) ATX Motherboard (PCIe 4.0,WiFi 6E, 2.5Gb LAN, BIOS Flashback, HDMI 2.1, Addressable Gen 2 RGB Header and Aura Sync)",
            Description = 
@"AM4 socket: Ready for AMD Ryzen 3000 and 5000 series, plus 5000 and 4000 G-series desktop processors.Bluetooth v5.2
Best gaming connectivity: PCIe 4.0-ready, dual M.2 slots, USB 3.2 Gen 2 Type-C, plus HDMI 2.1 and DisplayPort 1.2 output
Smooth networking: On-board WiFi 6E (802.11ax) and Intel 2.5 Gb Ethernet with ASUS LANGuard
Robust power solution: 12+2 teamed power stages with ProCool power connector, high-quality alloy chokes and durable capacitors
Renowned software: Bundled 60 days AIDA64 Extreme subscription and intuitive UEFI BIOS dashboard",
            Price = 180.99f,
            Category = "Motherboard",
            Image = "https://m.media-amazon.com/images/I/813WBwlPh+L._AC_SX679_.jpg",
            SKU = "B09GP7P1XS",
            Brand = "ASUS",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("8e874297-199f-4f7c-9875-c896aefd813a"),
            Name = "MSI A520M-A PRO Gaming Motherboard (AMD AM4, DDR4, PCIe 3.0, SATA 6Gb/s, M.2, USB 3.2 Gen 1, DVI/HDMI, Micro-ATX)",
            Description = 
@"Support 3rd Gen AMD Ryzen Desktop Processors and AMD Ryzen 4000 G-Series Desktop Processors
Supports DDR4 Memory, up to 4600(OC) MHz
Turbo M.2: Running at PCI-E Gen3 x4 maximizes performance for NVMe based SSDs
Audio Boost: Reward your ears with studio grade sound quality
Dragon Center: A brand new software which integrates all MSI exclusive tools with user friendly user interface",
            Price = 63.99f,
            Category = "Motherboard",
            Image = "https://m.media-amazon.com/images/I/81LKKjLD1pL._AC_SX679_.jpg",
            SKU = "B08GY3W5S8",
            Brand = "MSI",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("25879069-76d2-4c6d-9f80-41f31b755681"),
            Name = "GIGABYTE B550M DS3H AC (AM4 AMD/B550/Micro ATX/Dual M.2/SATA 6Gb/s/USB 3.2 Gen 1/PCIe 4.0/HMDI/DVI/DDR4/Motherboard)",
            Description = 
@"Supports AMD Ryzen 5000 Series/ 3rd Gen Ryzen and 3rd Gen Ryzen with Radeon Graphics Processors
Dual Channel ECC/ Non-ECC Unbuffered DDR4, 4 DIMMs
5+3 Phases Pure Digital VRM Solution with Low RDS(on) MOSFETs
Ultra Durable PCIe 4.0 Ready x16 Slot
Dual Ultra-Fast NVMe PCIe 4.0/3.0 M.2 Connectors",
            Price = 109.99f,
            Category = "Motherboard",
            Image = "https://m.media-amazon.com/images/I/61Pl0vNGwKL._AC_SX425_.jpg",
            SKU = "B08R5736B3",
            Brand = "Gigabyte",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("e9544553-45f9-40a6-afd9-bc7091f121b6"),
            Name = "ASUS Prime B550-PLUS AMD AM4 Zen 3 Ryzen 5000 & 3rd Gen Ryzen ATX Motherboard (PCIe 4.0, ECC Memory, 1Gb LAN, HDMI 2.1, DisPlayPort 1.2 (4K@60HZ), Addressable Gen 2 RGB Header and Aura Sync)",
            Description = 
@"AMD AM4 Socket and PCIe 4. 0: The perfect pairing for Zen 3 Ryzen 5000 & 3rd Gen AMD Ryzen CPUs
Ultrafast Connectivity: 1x PCIe4. 0 x16 SafeSlot, 1Gb LAN, dual M. 2 slots (NVMe SSD)—one with PCIe 4. 0 x4 connectivity, USB 3. 2 Gen 2 Type-A , HDMI 2. 1, 4K@60HZ, DisPlay port 1. 2 and Thunderbolt 3 header
Comprehensive Cooling: VRM heatsink, chipset heatsink, hybrid fan headers and Fan Xpert 2 utility
5X Protection III: all-round protection with LANGuard, DRAM overcurrent protection, overvoltage protection, SafeSlot Core safeguards and stainless-steel back I/O
Boosted Memory Performance: ASUS OptiMem proprietary trace layout allows memory kits to operate at higher frequencies with lower voltages to maximize system performance.",
            Price = 129.99f,
            Category = "Motherboard",
            Image = "https://m.media-amazon.com/images/I/91bMWZiA3SL._AC_SX679_.jpg",
            SKU = "B089CT5GDM",
            Brand = "ASUS",
            IsAvailable = false
        },
        new Product()
        {
            Id = new Guid("6ab88d84-b3cf-45f3-b4bf-2cc0b2ff454e"),
            Name = "SANSUI Monitor 24 inch 100Hz IPS USB Type-C FHD 1080P Computer Display Built-in Speakers HDMI DP HDR10 Game RTS/FPS Tilt Adjustable for Working and Gaming (ES-24X3 Type-C & HDMI Cable Included)",
            Description = 
@"SANSUI 24-inch monitor with 100Hz refresh rates and freesync can reject blur, jitter, tearing and ghosting in fast-paced action. Bring a smooth office enjoyment for you. RTS/FPS/RACING/Screen Assistance game modes also enhance the gaming experience and make PC gamers feel more immersive.
Visual Enjoyment and Unfettered ViewingThe FHD 1080p monitor 24 inch with IPS panel and three-sided edgeless design gives you clear and bright images. 178° wide viewing angle allow you to get more details and enjoy panoramic viewing.A richer level of light and dark picture has been supported by HDR10. 99.99% SRGB (72% NTSC) and 16.7M display colors make the image more vivid and rich for your perfect enjoyment.
Multiple Ports and Flexible ConnectivityJust one USB Type-C cable is needed to connect your USB C devices such as PCs, laptops, tablets, phones, game consoles, and more, allowing you screen sharing, image or video editing, movie watching and game playing freely. The 24 inch display with HDMI and DP ports allows quick connection to various devices for multimedia setups. The built-in speakers free up desk space and provide quality audio.
Eye Protection and Ergonomic Design】The 1080p monitor with Anti-Bluelight reduces harmful blue light during prolonged use, which can reduce eye strain. Anti-glare and anti-flicker technology eliminates irritating screen flicker for better eye protection. 24-inch monitor mounts for quick installation and removal, supports 75*75mm VESA mount with four M4 x 8 mm screw holes. Tilt 5 degrees forward and 15 degrees back to give you the best viewing angle.
Worry-Free After-Sales】Enjoy the Amazon Guarantee to get your money back or replacement within 30 days. We are committed to a 12-month warranty and lifetime free technical support. Any damage, malfunction or missing accessories, please feel free to contact us.",
            Price = 90.77f,
            Category = "Monitor",
            Image = "https://m.media-amazon.com/images/I/71Q5odbVSiL._AC_SX679_.jpg",
            SKU = "B0BRV78FWG",
            Brand = "SANSUI",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("0099b1ae-8cc7-4aab-941a-d28cb5b3a5d2"),
            Name = "SANSUI Computer Monitors 27 inch 100Hz IPS USB Type-C FHD 1080P HDR10 Built-in Speakers HDMI DP Game RTS/FPS tilt Adjustable for Working and Gaming (ES-27X3 Type-C Cable & HDMI Cable Included)",
            Description = 
@"27 Full HD IPS(1920*1080) HDR10 Monitor for Home, Game and Office
Refresh Rate: 100Hz, Response Time: 5ms with HDMI&DP; Brightness: 300Nits;Free Sync Technology, RTS/FPS/RACING/Screen Assistance
Interface& Speakers: 1×Type-C /HDMI 1.4/DP Ports (HDMI & Type-C Cable include); 2×2W Built-in Speakers
Ergonomic Design: V-shaped Saved Room Metal Stand, -5°~15°Tilt , 178°V/H Viewing Angle, 100×100mm VESA
Warranty: A 30-day money-back and free replacement warranty from order date and lifetime technical support.",
            Price = 113f,
            Category = "Monitor",
            Image = "https://m.media-amazon.com/images/I/71DA65jzsaL._AC_SX679_.jpg",
            SKU = "B0BRV7N7K1",
            Brand = "SANSUI",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("19825e0d-1814-44ec-bcc2-04ae50041be0"),
            Name = "Acer KB272 EBI 27 IPS Full HD (1920 x 1080) Zero-Frame Gaming Office Monitor | AMD FreeSync Technology | Up to 100Hz Refresh | 1ms (VRB) | Low Blue Light | Tilt | HDMI & VGA Ports,Black",
            Description = 
@"27 Full HD IPS (1920 x 1080) Monitor For Home, Gaming or Office
AMD FreeSync Technology
Response Time: 1ms VRB | Refresh Rate: 100Hz (Using HDMI Port) | Brightness: 250 nits | Pixel Pitch: 0.311mm
Ergonomic Tilt: -5° to 15° | VESA Mounting Compliant (100 x 100mm)
Ports: 1 x HDMI 1.4 Port & 1 x VGA Port (HDMI Cable Included)",
            Category = "Monitor",
            Price = 119.99f,
            Image = "https://m.media-amazon.com/images/I/81FTa3aSdnL._AC_SX679_.jpg",
            SKU = "B0BY9NPLP4",
            Brand = "Acer",
            IsAvailable = true
        },
        new Product()
        {
            Id = new Guid("025a2656-8a87-4d22-b0e5-35e019071716"),
            Name = "Turtle Beach Stealth 600 Gen 2 USB Wireless Amplified Gaming Headset - Licensed for Xbox Series X|S & Xbox One - 24+ Hour Battery, 50mm Speakers, Flip-to-Mute Mic, Spatial Audio – Black (Renewed)",
            Description = 
@"Officially Licensed by Microsoft for Xbox
Proprietary, Lag-free 2.4GHz Wireless Connection
Upgraded, 24+ Hour Battery Life
Gen 2 Mic for Clear chat with teammates
Powerful, amplified 50mm speakers tuned for surround sound",
            Category = "Headset",
            Price = 59.95f,
            Image = "https://m.media-amazon.com/images/I/81KNikS6HvL._SX466_.jpg",
            SKU = "B0C88B8DR2",
            Brand = "N/A",
            IsAvailable = true
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