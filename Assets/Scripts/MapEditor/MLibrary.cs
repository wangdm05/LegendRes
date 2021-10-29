using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using UnityEngine;
using System.Drawing;
using System.Drawing.Imaging;


public static class Libraries
{
    public static string resRoot = @"F:\热血传奇客户端\2017-4-6盛大9.2G客户端\Legend of mir\";
    public static bool Loaded;
    public static int Count, Progress;


    public static string LibPath = resRoot + @"Data\";
    public static string ShandaMir2LibPath = resRoot + @"Data\";

    public static string ObjectsPath = resRoot + @"Data\Objects\";
    //Map
    public static readonly MLibrary[] MapLibs = new MLibrary[400];

    public static readonly ListItem[] ListItems = new ListItem[400];

    static Libraries()
    {
        ////wemade mir2 (allowed from 0-99)
        //MapLibs[99] = new MLibrary(resRoot + @"Objects\MyImage");
        //MapLibs[0] = new MLibrary(resRoot + @"Data\Tiles");
        //ListItems[0] = new ListItem("Tiles", 0);
        //MapLibs[1] = new MLibrary(resRoot + @"Data\Smtiles");
        //ListItems[1] = new ListItem("Smtiles", 1);
        //MapLibs[2] = new MLibrary(resRoot + @"Data\Objects");
        //ListItems[2] = new ListItem("Objects", 2);
        //for (int i = 2; i < 24; i++)
        //{
        //    if (File.Exists(resRoot + @"Data\Objects" + i + ".wzx"))
        //    {
        //        MapLibs[i + 1] = new MLibrary(resRoot + @"Data\Objects" + i);
        //        ListItems[i + 1] = new ListItem("Objects" + i, i + 1);
        //    }
        //}

        //shanda mir2 (allowed from 100-199)   @"D:\热血传奇客户端\客户端\Legend of mir\Data\";
        MapLibs[100] = new MLibrary(resRoot + @"Data\Tiles");
        ListItems[100] = new ListItem(resRoot + @"Data\Tiles", 100);
        for (int i = 1; i < 10; i++)
        {
            MapLibs[100 + i] = new MLibrary(resRoot + @"Data\Tiles" + (i + 1));
            ListItems[100 + i] = new ListItem(resRoot + @"Data\Tiles" + (i + 1), 100 + i);

        }
        MapLibs[110] = new MLibrary(resRoot + @"Data\SmTiles");
        ListItems[110] = new ListItem(resRoot + @"Data\SmTiles", 110);
        for (int i = 1; i < 10; i++)
        {
            MapLibs[110 + i] = new MLibrary(resRoot + @"Data\SmTiles" + (i + 1));
            ListItems[110 + i] = new ListItem(resRoot + @"Data\SmTiles" + (i + 1), 110 + i);
        }
        MapLibs[120] = new MLibrary(resRoot + @"Data\Objects");
        ListItems[120] = new ListItem("Objects", 120);
        for (int i = 1; i < 31; i++)
        {
            MapLibs[120 + i] = new MLibrary(resRoot + @"Data\Objects" + (i + 1));
            ListItems[120 + i] = new ListItem(resRoot + @"Data\Objects" + (i + 1), 120 + i);
        }
        MapLibs[190] = new MLibrary(resRoot + @"Data\AniTiles1");
        ListItems[190] = new ListItem(resRoot + @"Data\AniTiles1", 190);
        //wemade mir3 (allowed from 200-299)
        string[] Mapstate = { "", "wood\\", "sand\\", "snow\\", "forest\\" };
        for (int i = 0; i < Mapstate.Length; i++)
        {
            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Tilesc" + ".lib"))
            {
                MapLibs[200 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Tilesc");
                ListItems[200 + (i * 15)] = new ListItem(Mapstate[i] + "Tilesc", 200 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Tiles30c" + ".lib"))
            {
                MapLibs[201 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Tiles30c");
                ListItems[201 + (i * 15)] = new ListItem(Mapstate[i] + "Tiles30c", 201 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Tiles5c" + ".lib"))
            {
                MapLibs[202 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Tiles5c");
                ListItems[202 + (i * 15)] = new ListItem(Mapstate[i] + "Tiles5c", 202 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Smtilesc" + ".lib"))
            {
                MapLibs[203 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Smtilesc");
                ListItems[203 + (i * 15)] = new ListItem(Mapstate[i] + "Smtilesc", 203 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Housesc" + ".lib"))
            {
                MapLibs[204 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Housesc");
                ListItems[204 + (i * 15)] = new ListItem(Mapstate[i] + "Housesc", 204 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Cliffsc" + ".lib"))
            {
                MapLibs[205 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Cliffsc");
                ListItems[205 + (i * 15)] = new ListItem(Mapstate[i] + "Cliffsc", 205 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Dungeonsc" + ".lib"))
            {
                MapLibs[206 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Dungeonsc");
                ListItems[206 + (i * 15)] = new ListItem(Mapstate[i] + "Dungeonsc", 206 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Innersc" + ".lib"))
            {
                MapLibs[207 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Innersc");
                ListItems[207 + (i * 15)] = new ListItem(Mapstate[i] + "Innersc", 207 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Furnituresc" + ".lib"))
            {
                MapLibs[208 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Furnituresc");
                ListItems[208 + (i * 15)] = new ListItem(Mapstate[i] + "Furnituresc", 208 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Wallsc" + ".lib"))
            {
                MapLibs[209 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Wallsc");
                ListItems[209 + (i * 15)] = new ListItem(Mapstate[i] + "Wallsc", 209 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "smObjectsc" + ".lib"))
            {
                MapLibs[210 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "smObjectsc");
                ListItems[210 + (i * 15)] = new ListItem(Mapstate[i] + "smObjectsc", 210 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Animationsc" + ".lib"))
            {
                MapLibs[211 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Animationsc");
                ListItems[211 + (i * 15)] = new ListItem(Mapstate[i] + "Animationsc", 211 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Object1c" + ".lib"))
            {
                MapLibs[212 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Object1c");
                ListItems[212 + (i * 15)] = new ListItem(Mapstate[i] + "Object1c", 212 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Object2c" + ".lib"))
            {
                MapLibs[213 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\WemadeMir3\" + Mapstate[i] + "Object2c");
                ListItems[213 + (i * 15)] = new ListItem(Mapstate[i] + "Object2c", 213 + (i * 15));
            }

        }


        //shanda mir3 (allowed from 300-399)
        Mapstate = new[] { "", "wood", "sand", "snow", "forest" };
        for (int i = 0; i < Mapstate.Length; i++)
        {
            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Tilesc" + Mapstate[i] + ".lib"))
            {
                MapLibs[300 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Tilesc" + Mapstate[i]);
                ListItems[300 + (i * 15)] = new ListItem("Tilesc" + Mapstate[i], 300 + (i * 15));
            }


            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Tiles30c" + Mapstate[i] + ".lib"))
            {
                MapLibs[301 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Tiles30c" + Mapstate[i]);
                ListItems[301 + (i * 15)] = new ListItem("Tiles30c" + Mapstate[i], 301 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Tiles5c" + Mapstate[i] + ".lib"))
            {
                MapLibs[302 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Tiles5c" + Mapstate[i]);
                ListItems[302 + (i * 15)] = new ListItem("Tiles5c" + Mapstate[i], 302 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Smtilesc" + Mapstate[i] + ".lib"))
            {
                MapLibs[303 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Smtilesc" + Mapstate[i]);
                ListItems[303 + (i * 15)] = new ListItem("Smtilesc" + Mapstate[i], 303 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Housesc" + Mapstate[i] + ".lib"))
            {
                MapLibs[304 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Housesc" + Mapstate[i]);
                ListItems[304 + (i * 15)] = new ListItem("Housesc" + Mapstate[i], 304 + (i * 15));
            }


            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Cliffsc" + Mapstate[i] + ".lib"))
            {
                MapLibs[305 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Cliffsc" + Mapstate[i]);
                ListItems[305 + (i * 15)] = new ListItem("Cliffsc" + Mapstate[i], 305 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Dungeonsc" + Mapstate[i] + ".lib"))
            {
                MapLibs[306 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Dungeonsc" + Mapstate[i]);
                ListItems[306 + (i * 15)] = new ListItem("Dungeonsc" + Mapstate[i], 306 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Innersc" + Mapstate[i] + ".lib"))
            {
                MapLibs[307 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Innersc" + Mapstate[i]);
                ListItems[307 + (i * 15)] = new ListItem("Innersc" + Mapstate[i], 307 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Furnituresc" + Mapstate[i] + ".lib"))
            {
                MapLibs[308 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Furnituresc" + Mapstate[i]);
                ListItems[308 + (i * 15)] = new ListItem("Furnituresc" + Mapstate[i], 308 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Wallsc" + Mapstate[i] + ".lib"))
            {

                MapLibs[309 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Wallsc" + Mapstate[i]);
                ListItems[309 + (i * 15)] = new ListItem("Wallsc" + Mapstate[i], 309 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "smObjectsc" + Mapstate[i] + ".lib"))
            {
                MapLibs[310 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "smObjectsc" + Mapstate[i]);
                ListItems[310 + (i * 15)] = new ListItem("smObjectsc" + Mapstate[i], 310 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Animationsc" + Mapstate[i] + ".lib"))
            {
                MapLibs[311 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Animationsc" + Mapstate[i]);
                ListItems[311 + (i * 15)] = new ListItem("Animationsc" + Mapstate[i], 311 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Object1c" + Mapstate[i] + ".lib"))
            {
                MapLibs[312 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Object1c" + Mapstate[i]);
                ListItems[312 + (i * 15)] = new ListItem("Object1c" + Mapstate[i], 312 + (i * 15));
            }

            if (File.Exists(resRoot + @"Data\Map\ShandaMir3\" + "Object2c" + Mapstate[i] + ".lib"))
            {
                MapLibs[313 + (i * 15)] = new MLibrary(resRoot + @"Data\Map\ShandaMir3\" + "Object2c" + Mapstate[i]);
                ListItems[313 + (i * 15)] = new ListItem("Object2c" + Mapstate[i], 313 + (i * 15));
            }
        }


        //Thread thread = new Thread(LoadGameLibraries) { IsBackground = true };
        //thread.Start();
    }


    public static void LoadGameLibraries()
    {
        Count = MapLibs.Length;

        for (int i = 0; i < MapLibs.Length; i++)
        {
            if (MapLibs[i] == null)
                MapLibs[i] = new MLibrary("");
            else
                MapLibs[i].Initialize("");
            Progress++;
        }
        Loaded = true;
    }

}



public sealed class MLibrary
{
    public const int LibVersion = 2;
    public static bool Load = true;
    public string FileName;

    public List<MImage> Images = new List<MImage>();
    public List<int> IndexList = new List<int>();
    public int Count;
    private bool _initialized;

    private BinaryReader _reader;
    private FileStream _stream;



    public MLibrary(string filename)
    {
        FileName = filename;
        Initialize("");
    }

    public BinaryReader _reader_wzl, _reader_wzl_wzx;
    public FileStream _stream_wzl, _stream_wzx;


    public void Initialize(string ss)
    {
        _initialized = true;

        try
        {
            if (!File.Exists(FileName + ".wzx"))//"D:\\热血传奇客户端\\热血传奇\\Data\\Mon19.Lib" humeffect8
                return;
            //c# 读写文件时文件正由另一进程使用，因此该进程无法访问该文件  不单要与只读方式打开txt文件，而且，需要共享锁。还必须要选择FileShare方式为ReadWrite。因为随时有其他程序对其进行写操作。
            _stream_wzx = new FileStream(FileName + ".wzx", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);////"D:\\热血传奇客户端\\热血传奇\\Data\\Tiles.wil"
            _stream_wzx.Seek(0, SeekOrigin.Begin);
            _reader_wzl_wzx = new BinaryReader(_stream_wzx);

            _stream_wzx.Seek(48, SeekOrigin.Begin);
            //   _count = _reader_wzl_wzx.ReadInt32();
            // 【Title和indexCount一共48字节,后面就是数据】  wix 其中前44字节为 INDX v1.0-WEMADE Entertainment inc.  后4字节为资源索引数组的长度占4个字节。。48字节以后的就是资源索引了。
            Count = (int)(_stream_wzx.Length - 48) / 4;
            Images = new List<MImage>();
            IndexList = new List<int>();
            for (int i = 0; i < Count; i++)  //索引集合
            {
                IndexList.Add(_reader_wzl_wzx.ReadInt32());
                Images.Add(null);
                //   _images[i]=null;
            }
            Close_stream_read_wzx(); //释放wzx的东西。韩国就没有释放。留着今后读取吧
            if (!File.Exists(FileName + ".wzl"))//"D:\\热血传奇客户端\\热血传奇\\Data\\Mon19.Lib"
                return;
            _stream_wzl = new FileStream(FileName + ".wzl", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            _reader_wzl = new BinaryReader(_stream_wzl);

            _stream_wzl.Seek(0, SeekOrigin.Begin);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void Initialize2()
    {
        int CurrentVersion;
        _initialized = true;

        if (!File.Exists(FileName))
            return;

        _stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
        _reader = new BinaryReader(_stream);
        CurrentVersion = _reader.ReadInt32();
        if (CurrentVersion != LibVersion)
        {
            Debug.LogError("Wrong version, expecting lib version: " + LibVersion.ToString() + " found version: " + CurrentVersion.ToString());
            return;
        }
        Count = _reader.ReadInt32();
        Images = new List<MImage>();
        IndexList = new List<int>();

        for (int i = 0; i < Count; i++)
            IndexList.Add(_reader.ReadInt32());

        for (int i = 0; i < Count; i++)
            Images.Add(null);

        //for (int i = 0; i < Count; i++)
        //    CheckImage(i);
    }


    public void Close_stream_read_wzx()
    {
        //释放wzx索引的资源。上面的是wzl资源还用到不释放。
        if (_stream_wzx != null)
            _stream_wzx.Dispose();

        if (_reader_wzl_wzx != null)
            _reader_wzl_wzx.Dispose();
    }

    public void Close()
    {
        if (_stream != null)
            _stream.Dispose();
        if (_reader != null)
            _reader.Dispose();
    }

    public void CheckImage(int index)
    {
        if (!_initialized)
            Initialize("");

        if (Images == null || index < 0 || index >= Images.Count)
            return;

        if (Images[index] == null)
        {
            // _stream.Position = IndexList[index];
            _stream_wzl.Position = IndexList[index];
            //  Images[index] = new MImage(_reader);
            Images[index] = new MImage(_stream_wzl, _reader_wzl, IndexList[index], index);
        }

        if (!Load) 
            return;
        //MImage mi = Images[index];
        //if (!mi.TextureValid)
        //{
        //    _stream.Seek(IndexList[index] + 12, SeekOrigin.Begin);
        //    mi.CreateTexture(_reader);
        //}

        if (!Images[index].TextureValid)
        {
            if (Images[index].Width * Images[index].Height < 4)   //如果宽和高都是0，就不用创建了
                return;

            Images[index].CreateBmpTexture(_reader_wzl, IndexList[index], _stream_wzl, index);
        }

        return;
    }

    public Size GetSize(int index)
    {
        if (!_initialized)
            Initialize("");
        if (Images == null || index < 0 || index >= Images.Count)
            return Size.Empty;

        if (Images[index] == null)
        {
            Images[index] = new MImage(_stream_wzl, _reader_wzl, IndexList[index], index);
        }

        return new Size(Images[index].Width, Images[index].Height);
    }

    public MImage GetMImage(int index)
    {
        if (index < 0 || index >= Images.Count)
            return null;
        CheckImage(index);
        return Images[index];
    }

    public void RemoveImage(int index)
    {
        if (Images == null || Count <= 1)
        {
            Count = 0;
            Images = new List<MImage>();
            return;
        }
        Count--;

        Images.RemoveAt(index);
    }

    public static bool CompareBytes(byte[] a, byte[] b)
    {
        if (a == b) return true;

        if (a == null || b == null || a.Length != b.Length) return false;

        for (int i = 0; i < a.Length; i++) if (a[i] != b[i]) return false;

        return true;
    }

    public void RemoveBlanks(bool safe = false)
    {
        for (int i = Count - 1; i >= 0; i--)
        {
            if (Images[i].FBytes == null || Images[i].FBytes.Length <= 24)
            {
                if (!safe)
                    RemoveImage(i);
                else if (Images[i].X == 0 && Images[i].Y == 0)
                    RemoveImage(i);
            }
        }
    }

    public class MImage
    {
        public short Width, Height, X, Y, ShadowX, ShadowY;
        public byte Shadow;
        public int Length;
        public byte[] FBytes;
        public bool TextureValid;
        public Bitmap Image;
        public Texture2D ImageTexture;

        //layer 2:
        public short MaskWidth, MaskHeight, MaskX, MaskY;

        public int MaskLength;
        public byte[] MaskFBytes;
        public Bitmap MaskImage;
        public Texture MaskImageTexture;
        public Boolean HasMask;

        public unsafe byte* Data;

        public MImage(FileStream _stream_wil, BinaryReader _reader_wzl, long Position, int index)
        {
            if (Position == 0) return; //// 方便装备衣服物品设置为0时，不会出错误

            _stream_wil.Position = Position;
            this.bo16bit = (_reader_wzl.ReadByte() == 5 ? true : false);//1
            _reader_wzl.ReadBytes(3);//

            this.Width = _reader_wzl.ReadInt16();//2
            this.Height = _reader_wzl.ReadInt16();//2

            this.X = (short)(_reader_wzl.ReadInt16());//2
            this.Y = (short)(_reader_wzl.ReadInt16());//2

            ////破天魔龙的绘制出现了X轴方向的便宜。修复如下：
            //if (文件名字 == 破天魔龙)//破天魔龙这个怪。应该往右边便宜一个格子才对。一个格子是32宽。所以这种修复方式正确
            //{
            //    this.X = (short)(_reader_wzl.ReadInt16() - 32);//2
            //}
            //else
            //{
            //    this.X = _reader_wzl.ReadInt16();//2
            //}


            this.nSize = _reader_wzl.ReadInt32();//4

            //if (this.Width%2==1)
            //{
            //    this.Width += 1;
            //}
            //this.Width = (this.nSize == 0) ? (short)0 : this.Width;

        }



        public MImage(BinaryReader reader)
        {
            //read layer 1
            Width = reader.ReadInt16();
            Height = reader.ReadInt16();
            X = reader.ReadInt16();
            Y = reader.ReadInt16();
            ShadowX = reader.ReadInt16();
            ShadowY = reader.ReadInt16();
            Shadow = reader.ReadByte();
            Length = reader.ReadInt32();
            FBytes = reader.ReadBytes(Length);
            //check if there's a second layer and read it
            HasMask = ((Shadow >> 7) == 1) ? true : false;
            if (HasMask)
            {
                MaskWidth = reader.ReadInt16();
                MaskHeight = reader.ReadInt16();
                MaskX = reader.ReadInt16();
                MaskY = reader.ReadInt16();
                MaskLength = reader.ReadInt32();
                MaskFBytes = reader.ReadBytes(MaskLength);
            }
        }

        public MImage(Bitmap image)
        {
            if (image == null)
            {
                FBytes = new byte[0];
                return;
            }

            Width = (short)image.Width;
            Height = (short)image.Height;

            Image = image;// FixImageSize(image);
            FBytes = ConvertBitmapToArray(Image);
        }

        public unsafe byte[] ConvertBitmapToArray(Bitmap input)
        {
            System.Drawing.Imaging.BitmapData data = input.LockBits(new System.Drawing.Rectangle(0, 0, input.Width, input.Height), ImageLockMode.ReadOnly,
                                                PixelFormat.Format32bppArgb);

            byte[] pixels = new byte[input.Width * input.Height * 4];
            Marshal.Copy(data.Scan0, pixels, 0, pixels.Length);

            input.UnlockBits(data);

            for (int i = 0; i < pixels.Length; i += 4)
            {
                if (pixels[i] == 0 && pixels[i + 1] == 0 && pixels[i + 2] == 0)
                    pixels[i + 3] = 0; //Make Transparent
            }

            byte[] compressedBytes;
            compressedBytes = Compress(pixels);

            return compressedBytes;
        }


        public bool bo16bit { get; set; }
        public int nSize { get; set; }

        public static int[] _palette = new int[256] { 0, -8388608, -16744448, -8355840, -16777088, -8388480, -16744320, -4144960, -11173737, -6440504, -8686733, -13817559, -10857902, -10266022, -12437191, -14870504, -15200240, -14084072, -15726584, -886415, -2005153, -42406, -52943, -2729390, -7073792, -7067368, -13039616, -9236480, -4909056, -4365486, -12445680, -21863, -10874880, -9225943, -5944783, -7046285, -4369871, -11394800, -8703720, -13821936, -7583183, -7067392, -4378368, -3771566, -9752296, -3773630, -3257856, -5938375, -10866408, -14020608, -15398912, -12969984, -16252928, -14090240, -11927552, -6488064, -2359296, -2228224, -327680, -6524078, -7050422, -9221591, -11390696, -7583208, -7846895, -11919104, -14608368, -2714534, -3773663, -1086720, -35072, -5925756, -12439263, -15200248, -14084088, -14610432, -13031144, -7576775, -12441328, -9747944, -8697320, -7058944, -7568261, -9739430, -11910599, -14081768, -12175063, -4872812, -8688806, -3231340, -5927821, -7572646, -4877197, -2710157, -1071798, -1063284, -8690878, -9742791, -4352934, -10274560, -2701651, -11386327, -7052520, -1059155, -5927837, -10266038, -4348549, -10862056, -4355023, -13291223, -7043997, -8688822, -5927846, -10859991, -6522055, -12439280, -1069791, -15200256, -14081792, -6526208, -7044006, -11386344, -9741783, -8690911, -6522079, -2185984, -10857927, -13555440, -3228293, -10266055, -7044022, -3758807, -15688680, -12415926, -13530046, -15690711, -16246768, -16246760, -16242416, -15187415, -5917267, -9735309, -15193815, -15187382, -13548982, -10238242, -12263937, -7547153, -9213127, -532935, -528500, -530688, -9737382, -10842971, -12995089, -11887410, -13531979, -13544853, -2171178, -4342347, -7566204, -526370, -16775144, -16246727, -16248791, -16246784, -16242432, -16756059, -16745506, -15718070, -15713941, -15707508, -14591323, -15716006, -15711612, -13544828, -15195855, -11904389, -11375707, -14075549, -15709474, -14079711, -11908551, -14079720, -11908567, -8684734, -6513590, -10855895, -12434924, -13027072, -10921728, -3525332, -9735391, -14077696, -13551344, -13551336, -12432896, -11377896, -10849495, -13546984, -15195904, -15191808, -15189744, -10255286, -9716406, -10242742, -10240694, -10838966, -11891655, -10238390, -10234294, -11369398, -13536471, -10238374, -11354806, -15663360, -15193832, -11892662, -11868342, -16754176, -16742400, -16739328, -16720384, -16716288, -16712960, -11904364, -10259531, -8680234, -9733162, -8943361, -3750194, -7039844, -6515514, -13553351, -14083964, -15204220, -11910574, -11386245, -10265997, -3230217, -7570532, -8969524, -2249985, -1002454, -2162529, -1894477, -1040, -6250332, -8355712, -65536, -16711936, -256, -16776961, -65281, -16711681, -1 };

        public unsafe void CreateBmpTexture(BinaryReader reader, long index_long, FileStream fStream, int _index)
        {
            //if (reader.BaseStream.Position == 0) return;
            //bo16bit = reader.ReadByte() == 5;
            //reader.ReadBytes(3);
            //Width = reader.ReadInt16();//80    8
            //Height = reader.ReadInt16();//71   13
            //X = reader.ReadInt16();
            //Y = reader.ReadInt16();
            //nSize = reader.ReadInt32();//2833
            //if (Width * Height < 4)
            //{
            //    return;
            //}
            fStream.Seek(index_long + (16), SeekOrigin.Begin);//80     127866- 127757=    109

            this.Image = new System.Drawing.Bitmap(Width, Height);
            System.Drawing.Imaging.BitmapData data = Image.LockBits(new System.Drawing.Rectangle(0, 0, Width, Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            byte[] bytes;

            if (nSize == 0)
            {
                bytes = reader.ReadBytes(this.bo16bit ? Width * Height * 2 : Width * Height);
            }
            else
            {
                using (MemoryStream output = new MemoryStream())
                {
                    using (Ionic.Zlib.ZlibStream deflateStream = new Ionic.Zlib.ZlibStream(output, Ionic.Zlib.CompressionMode.Decompress))
                    {
                        deflateStream.Write(reader.ReadBytes(nSize), 0, nSize);//得到图片数据大小,并且写入
                        bytes = output.ToArray();//--------得到解压后的原始数据      {by
                    }
                }
            }


            int index = 0, peet, color;
            byte alpha, alpha_temp;
            if (bytes.Length == Height * Width * 2.5)
            {
                int HW_2 = Height * Width * 2;
                int* scan0 = (int*)data.Scan0;
                {
                    for (int y = Height - 1; y >= 0; y--)
                    {
                        //---------------------------------------------------------------------------
                        for (int x = 0; x < Width; x++)
                        {
                            if (bo16bit)
                            {
                                alpha_temp = bytes[HW_2 + y * Width / 2 + x / 2];
                                alpha = (x % 2 != 0) ? ((byte)((alpha_temp & 0xf) * 17)) : ((byte)(((alpha_temp & 0xf0) >> 4) * 17)); // 透明值
                                color = bytes[index++] + (bytes[index++] << 8);
                                color = (((((color & 0xf800) >> 8)) << 0x10) | ((((color & 0x07e0) >> 3)) << 0x8) | (((color & 0x001f) << 3))) | (alpha << 24);
                                scan0[y * this.Width + x] = (color & 0xFFFFFF) == 0 ? 0 : color;
                                //scan0[y * Width + x] = convert16bitTo32bit2(bytes[index++] + ((bytes[index++] << 8)), bytes[HW_2 + y * Width / 2 + x / 2], x);
                            }
                            else
                                scan0[y * Width + x] = _palette[bytes[index++]];
                        }
                        if ((Width % 4) > 0)
                            index += WidthBytes(bo16bit ? 16 : 8, Width) - (Width * (bo16bit ? 2 : 1));
                        //------------------------------------------------------------------------------------------

                    }
                }
            }
            else
            {
                int* scan0 = (int*)data.Scan0;
                {
                    for (int y = Height - 1; y >= 0; y--)
                    {
                        //---------------------------------------------------------------------------
                        for (int x = 0; x < Width; x++)
                        {
                            if (bo16bit)
                            {
                                color = bytes[index++] + (bytes[index++] << 8);
                                color = (((((color & 0xf800) >> 8)) << 0x10) | ((((color & 0x07e0) >> 3)) << 0x8) | (((color & 0x001f) << 3))) | (255 << 24);
                                scan0[y * this.Width + x] = (color & 0xFFFFFF) == 0 ? 0 : color;
                            }
                            else
                                scan0[y * Width + x] = _palette[bytes[index++]];
                        }
                        if ((Width % 4) > 0)
                            index += WidthBytes(bo16bit ? 16 : 8, Width) - (Width * (bo16bit ? 2 : 1));
                        //------------------------------------------------------------------------------------------

                    }
                }
            }

            Image.UnlockBits(data);
            bytes = null;
        }

        private int convert16bitTo32bit2(int temp, byte bb, int x) //16位分为5位红，5位蓝，6位绿。          2的16次方，可以表现65536种颜色
        {

            byte red = (byte)((temp & 0xf800) >> 8); // 0xf800  红   1111 1000 0000 0000 （右移动8位之后，就是0000 0000 1111 1000 然后强制转换为一个字节byte  既1111 1000）
            byte green = (byte)((temp & 0x07e0) >> 3);//0x07e0  绿         111 1110 0000 （右移3位就是 000 1111 1100转为byte）
            byte blue = (byte)((temp & 0x001f) << 3); //0x001f  蓝                1 1111  （左移3位就是    1111 1000转为byte）

            //int aa1 = ((bb & 0xf0) >> 4) * 17;
            //int aa2 = (int)((bb & 0xf) * 17);
            //byte alpha = (x % 2 != 0) ? ((byte)aa2) : ((byte)aa1);

            byte alpha = (x % 2 != 0) ? ((byte)((bb & 0xf) * 17)) : ((byte)(((bb & 0xf0) >> 4) * 17)); // 透明值

            return (
                    (red << 0x10)     // 0x10      1 0000    十进制 为 16   左移16位（原来在8位。左移16位就在24位上---16--24之间）
                    | (green << 0x8)   //  1000    十进制 为 8    左移16位（green原来在8位。左移16位就在24位上---8--16之间,blue在0--8之间）
                    | blue)  //0x8         1000    十进制 为 8    左移16位（green原来在8位。左移16位就在24位上---8--16之间,blue在0--8之间）
                    | (alpha << 24);//the final or is setting alpha to max so it'll display (since mir2 images have no alpha layer)


            //return (
            //   ((byte)((temp & 0xf800) >> 8) << 0x10)     // 0x10      1 0000    十进制 为 16   左移16位（原来在8位。左移16位就在24位上---16--24之间）
            // | ((byte)((temp & 0x07e0) >> 3) << 0x8)   //  1000    十进制 为 8    左移16位（green原来在8位。左移16位就在24位上---8--16之间,blue在0--8之间）
            // | (byte)((temp & 0x001f) << 3))  //0x8         1000    十进制 为 8    左移16位（green原来在8位。左移16位就在24位上---8--16之间,blue在0--8之间）
            // | ((x % 2 != 0) ? ((byte)((bb & 0xf) * 17)) : ((byte)(((bb & 0xf0) >> 4) * 17)) << 24);//the final or is setting alpha to max so it'll display (since mir2 images have no alpha layer)

        }
        private int convert16bitTo32bit3(int color)
        {
            byte red = (byte)((color & 0xf800) >> 8);
            byte green = (byte)((color & 0x07e0) >> 3);
            byte blue = (byte)((color & 0x001f) << 3);
            if (red == 0 && green == 0 && blue == 0)
            {
                return 0;
            }
            return ((red << 0x10) | (green << 0x8) | blue) | (255 << 24);

            //byte red = (byte)((color & 0xf800) >> 8);
            //byte green = (byte)((color & 0x07e0) >> 3);
            //byte blue = (byte)((color & 0x001f) << 3);
            //return (((byte)((color & 0xf800) >> 8) << 0x10) | ((byte)((color & 0x07e0) >> 3) << 0x8) | (byte)((color & 0x001f) << 3)) | (255 << 24);
        }


        private int WidthBytes(int nBit, int nWidth)
        {
            return (((nWidth * nBit) + 31) >> 5) * 4;
        }




        public void Save(BinaryWriter writer)
        {
            writer.Write(Width);
            writer.Write(Height);
            writer.Write(X);
            writer.Write(Y);
            writer.Write(ShadowX);
            writer.Write(ShadowY);
            writer.Write(HasMask ? (byte)(Shadow | 0x80) : (byte)Shadow);
            writer.Write(FBytes.Length);
            writer.Write(FBytes);
            if (HasMask)
            {
                writer.Write(MaskWidth);
                writer.Write(MaskHeight);
                writer.Write(MaskX);
                writer.Write(MaskY);
                writer.Write(MaskFBytes.Length);
                writer.Write(MaskFBytes);
            }
        }

        public static byte[] Compress(byte[] raw)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory,
                CompressionMode.Compress, true))
                {
                    gzip.Write(raw, 0, raw.Length);
                }
                return memory.ToArray();
            }
        }

        static byte[] Decompress(byte[] gzip)
        {
            // Create a GZIP stream with decompression mode.
            // ... Then create a buffer and write into while reading from the GZIP stream.
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip), CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return memory.ToArray();
                }
            }
        }

        private static byte[] DecompressImage(byte[] image)
        {
            using (GZipStream stream = new GZipStream(new MemoryStream(image), CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return memory.ToArray();
                }
            }
        }
    }
}
