using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public enum EnumResType
{
    all,      //所有
    player,   //角色
    hair,     //头饰
    weapon,   //武器
    bmpToPng, //bmp转png
    wing,     //翅膀导出
    ui,       //ui导出
    npc,      //npc
    npc1,     //npc1
    effect,
    effect1,
    effect2,
    effect3,
    effect4,
    effect5,
    effect6,
    effect7,
    effect8,
    effect9,
    effect10,
    effect11,
    monster1,  //怪物
    monster2,  //怪物1
    monster3,  //怪物2
    monster4,  //怪物3
    monster5,  //怪物4
    monster6,  //怪物5
    monster7,  //怪物6
    monster8,  //怪物7
    monster9,  //怪物8
    monster10,  //怪物9
    monster11,  //怪物10
    monster12,  //怪物11
    monster13,  //怪物12
    monster14,  //怪物13
    monster15,  //怪物14
    monster16,  //怪物15
    monster17,  //怪物16
    monster18,  //怪物17
    monster19,  //怪物18
    monster20,  //怪物19
    monster21,  //怪物20
    monster22,  //怪物21
    monster23,  //怪物22
    monster24,  //怪物23
    monster25,  //怪物24
    monster26,  //怪物25
    monster27,  //怪物26
    monster28,  //怪物27
    monster29,  //怪物28
    monster30,  //怪物29
    monster31,  //怪物30
    monster32,  //怪物31
    monster33,  //怪物32
    monster34,  //怪物33
    monster35,  //怪物34
    monster36,  //怪物35
    monster37,  //怪物36
    monster38,  //怪物37
    monster39,  //怪物38
    monster40,  //怪物39
    monster41,  //怪物40
    monster42,  //怪物41
}

public class ResTypeTools
{
    private static string rootPath = Application.dataPath + @"\..\";
    private static string ssdRootPath = @"E:\";
    private static int monsterResType = 1000;
    private static int effectResType = 10000;
    private static int monsterResIndex = 0;

    //删除空贴图和空文本路径
    private static List<string> sourcePaths = new List<string>
    {
        #region 主角
        ssdRootPath + @"RXCQ\bmp\Hum",
        ssdRootPath + @"RXCQ\bmp\hum2",
        ssdRootPath + @"RXCQ\bmp\hum3",
        ssdRootPath + @"RXCQ\bmp\hair2",
        ssdRootPath + @"RXCQ\bmp\Weapon",
        ssdRootPath + @"RXCQ\bmp\weapon2",
        ssdRootPath + @"RXCQ\bmp\weapon3",
        ssdRootPath + @"RXCQ\bmp\weapon9",
        ssdRootPath + @"RXCQ\bmp\humeffect",
        #endregion

        #region ui
        ssdRootPath + @"RXCQ\bmp\ui\ChrSel",
        ssdRootPath + @"RXCQ\bmp\ui\DnItems",
        ssdRootPath + @"RXCQ\bmp\ui\Items",
        ssdRootPath + @"RXCQ\bmp\ui\magicon",
        ssdRootPath + @"RXCQ\bmp\ui\magicon2",
        ssdRootPath + @"RXCQ\bmp\ui\mmap",
        ssdRootPath + @"RXCQ\bmp\ui\Prguse",
        ssdRootPath + @"RXCQ\bmp\ui\Prguse2",
        ssdRootPath + @"RXCQ\bmp\ui\Prguse3",
        ssdRootPath + @"RXCQ\bmp\ui\ui_common",
        ssdRootPath + @"RXCQ\bmp\ui\ui1",
        ssdRootPath + @"RXCQ\bmp\ui\ui2",
        ssdRootPath + @"RXCQ\bmp\ui\ui3",
        #endregion

        #region 怪物
        ssdRootPath + @"RXCQ\bmp\monster\dragon",
        ssdRootPath + @"RXCQ\bmp\monster\Mon1",
        ssdRootPath + @"RXCQ\bmp\monster\Mon2",
        ssdRootPath + @"RXCQ\bmp\monster\Mon3",
        ssdRootPath + @"RXCQ\bmp\monster\Mon4",
        ssdRootPath + @"RXCQ\bmp\monster\Mon5",
        ssdRootPath + @"RXCQ\bmp\monster\Mon6",
        ssdRootPath + @"RXCQ\bmp\monster\mon7",
        ssdRootPath + @"RXCQ\bmp\monster\Mon8",
        ssdRootPath + @"RXCQ\bmp\monster\mon9",
        ssdRootPath + @"RXCQ\bmp\monster\mon10",
        ssdRootPath + @"RXCQ\bmp\monster\Mon11",
        ssdRootPath + @"RXCQ\bmp\monster\mon12",
        ssdRootPath + @"RXCQ\bmp\monster\mon13",
        ssdRootPath + @"RXCQ\bmp\monster\mon14",
        ssdRootPath + @"RXCQ\bmp\monster\mon15",
        ssdRootPath + @"RXCQ\bmp\monster\mon16",
        ssdRootPath + @"RXCQ\bmp\monster\mon17",
        ssdRootPath + @"RXCQ\bmp\monster\mon18",
        ssdRootPath + @"RXCQ\bmp\monster\mon19",
        ssdRootPath + @"RXCQ\bmp\monster\mon20",
        ssdRootPath + @"RXCQ\bmp\monster\mon21",
        ssdRootPath + @"RXCQ\bmp\monster\mon22",
        ssdRootPath + @"RXCQ\bmp\monster\mon23",
        ssdRootPath + @"RXCQ\bmp\monster\mon24",
        ssdRootPath + @"RXCQ\bmp\monster\mon25",
        ssdRootPath + @"RXCQ\bmp\monster\mon26",
        ssdRootPath + @"RXCQ\bmp\monster\mon27",
        ssdRootPath + @"RXCQ\bmp\monster\mon28",
        ssdRootPath + @"RXCQ\bmp\monster\mon29",
        ssdRootPath + @"RXCQ\bmp\monster\mon30",
        ssdRootPath + @"RXCQ\bmp\monster\mon31",
        ssdRootPath + @"RXCQ\bmp\monster\mon32",
        ssdRootPath + @"RXCQ\bmp\monster\mon33",
        ssdRootPath + @"RXCQ\bmp\monster\mon34",
        ssdRootPath + @"RXCQ\bmp\monster\mon35",
        ssdRootPath + @"RXCQ\bmp\monster\mon36",
        ssdRootPath + @"RXCQ\bmp\monster\mon37",
        ssdRootPath + @"RXCQ\bmp\monster\mon38",
        ssdRootPath + @"RXCQ\bmp\monster\mon39",
        ssdRootPath + @"RXCQ\bmp\monster\mon40",
        ssdRootPath + @"RXCQ\bmp\monster\mon41",
        ssdRootPath + @"RXCQ\bmp\monster\Mon-kulou",
        #endregion

        #region NPC
        ssdRootPath + @"RXCQ\bmp\npc",
        ssdRootPath + @"RXCQ\bmp\npc2",
        #endregion

        #region Effect
        ssdRootPath + @"RXCQ\bmp\magic\Magic",
        ssdRootPath + @"RXCQ\bmp\magic\magic2",
        ssdRootPath + @"RXCQ\bmp\magic\magic3",
        ssdRootPath + @"RXCQ\bmp\magic\magic4",
        ssdRootPath + @"RXCQ\bmp\magic\magic5",
        ssdRootPath + @"RXCQ\bmp\magic\magic6",
        ssdRootPath + @"RXCQ\bmp\magic\magic7",
        ssdRootPath + @"RXCQ\bmp\magic\magic7-16",
        ssdRootPath + @"RXCQ\bmp\magic\magic8",
        ssdRootPath + @"RXCQ\bmp\magic\magic8-16",
        ssdRootPath + @"RXCQ\bmp\magic\magic9",
        ssdRootPath + @"RXCQ\bmp\magic\magic10",
        #endregion
    };

    private static Dictionary<bool, string> genderFileNames = new Dictionary<bool, string>
    {
        [false] = "男模", [true] = "女模"
    };

    private static Dictionary<MirAction, string> eToc = new Dictionary<MirAction, string>
    {
        [MirAction.ShiFa] = "施法",
        [MirAction.Attack1] = "攻击",
        [MirAction.Attack2] = "攻击1",
        [MirAction.Attack3] = "攻击2",
        [MirAction.Attack4] = "攻击3",
        [MirAction.Attack5] = "攻击4",
        [MirAction.BeiJi] = "被击",

        [MirAction.BeiZhan] = "备战",
        [MirAction.Die] = "死亡",
        [MirAction.Die1] = "死亡1",
        [MirAction.Running] = "跑步",
        [MirAction.ShiQu] = "拾取",
        [MirAction.Standing] = "待机",
        [MirAction.Walking] = "走路",
        [MirAction.Skill] = "技能",
        [MirAction.Skill1] = "技能1",
        [MirAction.Skill2] = "技能2",
        [MirAction.Skill3] = "技能3",
        [MirAction.Skill4] = "技能4",
        [MirAction.Skill5] = "技能5",
        [MirAction.Skill6] = "技能6",
        [MirAction.Skill7] = "技能7",
        [MirAction.Standing1] = "待机1",
        [MirAction.Standing2] = "待机2",
        [MirAction.Weapon1] = "武器",
        [MirAction.Weapon2] = "武器1",
        [MirAction.BianShen] = "变身",
    };

    private static Dictionary<EnumResType, List<string>> sourcePaths_Type = new Dictionary<EnumResType, List<string>>()
    {
        [EnumResType.all] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\Hum",
            ssdRootPath + @"RXCQ\bmp\hum2",
            ssdRootPath + @"RXCQ\bmp\hum3",
            ssdRootPath + @"RXCQ\bmp\hair2",
            ssdRootPath + @"RXCQ\bmp\Weapon",
            ssdRootPath + @"RXCQ\bmp\weapon2",
            ssdRootPath + @"RXCQ\bmp\weapon3",
            ssdRootPath + @"RXCQ\bmp\weapon9",
        },

        //重组角色资源
        [EnumResType.player] = new List<string> 
        {
            ssdRootPath + @"RXCQ\bmp\Hum",
            ssdRootPath + @"RXCQ\bmp\hum2",
            ssdRootPath + @"RXCQ\bmp\hum3",
        },

        //重组头饰资源
        [EnumResType.hair] = new List<string> 
        {
            ssdRootPath + @"RXCQ\bmp\hair2",
        },

        //重组武器资源
        [EnumResType.weapon] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\Weapon",
            ssdRootPath + @"RXCQ\bmp\weapon2",
            ssdRootPath + @"RXCQ\bmp\weapon3",
            ssdRootPath + @"RXCQ\bmp\weapon9",
        },

        [EnumResType.bmpToPng] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\dbsj",
        },

        [EnumResType.wing] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\humeffect",
        },


        [EnumResType.ui] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\ui\ChrSel",
            ssdRootPath + @"RXCQ\bmp\ui\DnItems",
            ssdRootPath + @"RXCQ\bmp\ui\Items",
            ssdRootPath + @"RXCQ\bmp\ui\magicon",
            ssdRootPath + @"RXCQ\bmp\ui\magicon2",
            ssdRootPath + @"RXCQ\bmp\ui\mmap",
            ssdRootPath + @"RXCQ\bmp\ui\Prguse",
            ssdRootPath + @"RXCQ\bmp\ui\Prguse2",
            ssdRootPath + @"RXCQ\bmp\ui\Prguse3",
            ssdRootPath + @"RXCQ\bmp\ui\ui_common",
            ssdRootPath + @"RXCQ\bmp\ui\ui1",
            ssdRootPath + @"RXCQ\bmp\ui\ui2",
            ssdRootPath + @"RXCQ\bmp\ui\ui3",
        },

        [EnumResType.npc] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\npc",
        },

        [EnumResType.npc1] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\npc2",
        },

        #region Monster
        [EnumResType.monster1] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\Mon1",
        },

        [EnumResType.monster2] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\Mon2",
        },

        [EnumResType.monster3] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\Mon3",
        },

        [EnumResType.monster4] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\Mon4",
        },

        [EnumResType.monster5] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\Mon5",
        },

        [EnumResType.monster6] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\Mon6",
        },

        [EnumResType.monster7] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon7",
        },

        [EnumResType.monster8] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\Mon8",
        },

        [EnumResType.monster9] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon9",
        },

        [EnumResType.monster10] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon10",
        },

        [EnumResType.monster11] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\Mon11",
        },

        [EnumResType.monster12] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon12",
        },

        [EnumResType.monster13] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon13",
        },

        [EnumResType.monster14] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon14",
        },

        [EnumResType.monster15] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon15",
        },

        [EnumResType.monster16] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon16",
        },

        [EnumResType.monster17] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon17",
        },

        [EnumResType.monster18] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon18",
        },

        [EnumResType.monster19] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon19",
        },

        [EnumResType.monster20] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon20",
        },

        [EnumResType.monster21] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon21",
        },

        [EnumResType.monster22] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon22",
        },

        [EnumResType.monster23] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon23",
        },

        [EnumResType.monster24] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon24",
        },

        [EnumResType.monster25] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon25",
        },

        [EnumResType.monster26] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon26",
        },

        [EnumResType.monster27] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon27",
        },

        [EnumResType.monster28] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon28",
        },

        [EnumResType.monster29] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon29",
        },

        [EnumResType.monster30] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon30",
        },

        [EnumResType.monster31] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon31",
        },

        [EnumResType.monster32] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon32",
        },

        [EnumResType.monster33] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon33",
        },

        [EnumResType.monster34] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon34",
        },

        [EnumResType.monster35] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon35",
        },

        [EnumResType.monster36] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon36",
        },

        [EnumResType.monster37] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon37",
        },

        [EnumResType.monster38] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon38",
        },

        [EnumResType.monster39] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon39",
        },

        [EnumResType.monster40] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon40",
        },

        [EnumResType.monster41] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\mon41",
        },

        [EnumResType.monster42] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\monster\Mon-kulou",
        },
        #endregion

        #region Effect
        [EnumResType.effect] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\Magic",
        },

        [EnumResType.effect1] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\magic2",
        },

        [EnumResType.effect2] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\magic3",
        },

        [EnumResType.effect3] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\magic4",
        },

        [EnumResType.effect4] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\magic5",
        },

        [EnumResType.effect5] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\magic6",
        },

        [EnumResType.effect6] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\magic7",
        },

        [EnumResType.effect7] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\magic7-16",
        },

        [EnumResType.effect8] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\magic8",
        },

        [EnumResType.effect9] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\magic8-16",
        },

        [EnumResType.effect10] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\magic9",
        },

        [EnumResType.effect11] = new List<string>
        {
            ssdRootPath + @"RXCQ\bmp\magic\magic10",
        },

        #endregion
    };

    private static string outPngParentPath = ssdRootPath + @"RXCQ\png\";

    [MenuItem("Tools/热血传奇怀旧/重命名")]
    public static void RenameTools()
    {
        foreach (string sourcePath in sourcePaths)
        {
            Rename(sourcePath);
        }
    }

    [MenuItem("Tools/热血传奇怀旧/删除空白图片")]
    public static void DeleteTexture()
    {
        int pathIndex = 1;
        foreach (string sourcePath in sourcePaths)
        {
            List<string> pointPaths = Utils.FindFiles(sourcePath, "*.txt");
            float index = 0;
            foreach (string pointPath in pointPaths)
            {
                index++;
                string text = File.ReadAllText(pointPath);
                string fileName = Path.GetFileNameWithoutExtension(pointPath);

                DirectoryInfo directoryInfo = new DirectoryInfo(pointPath);
                string bmpParentPath = directoryInfo.Parent.Parent.FullName;
                string bmpPath = bmpParentPath + @"\" + fileName + @".bmp";

                TextureSize TextureSize = Utils.GetBmpWidthHeight(bmpPath);

                if (TextureSize.width == 1 && TextureSize.height == 1)
                {
                    if (File.Exists(bmpPath))
                        File.Delete(bmpPath);

                    if (File.Exists(pointPath))
                        File.Delete(pointPath);
                }

                EditorUtility.DisplayProgressBar("删除空白图片" + string.Format("{0} - {1}, {2}/{3}", pathIndex, sourcePaths.Count, index, pointPaths.Count), pointPath, index / (float)pointPaths.Count);
            }

            pathIndex++;
            EditorUtility.ClearProgressBar();
            Rename(sourcePath);
        }
    }

    [MenuItem("Tools/热血传奇怀旧/Player/资源重组-(头饰，武器，角色)")]
    public static void ResType_All()
    {
        ResType(EnumResType.all);
    }

    [MenuItem("Tools/热血传奇怀旧/Player/资源重组-头饰")]
    public static void ResType_Hair()
    {
        ResType(EnumResType.hair);
    }

    [MenuItem("Tools/热血传奇怀旧/Player/资源重组-武器")]
    public static void ResType_Weapon()
    {
        ResType(EnumResType.weapon);
    }

    [MenuItem("Tools/热血传奇怀旧/Player/资源重组-角色")]
    public static void ResType_Player()
    {
        ResType(EnumResType.player);
    }

    [MenuItem("Tools/热血传奇怀旧/Player/资源重组-翅膀")]
    public static void ResType_Wing()
    {
        ResType(EnumResType.wing);
    }

    [MenuItem("Tools/热血传奇怀旧/UI/资源重组-ui")]
    public static void ResType_UI()
    {
        UIBmpToPng(EnumResType.ui);
    }

    #region Monster
    [MenuItem("Tools/热血传奇怀旧/Monster/资源重组-所有怪物")]
    public static void ResType_AllMonster()
    {
        ResType_Monster1();
        ResType_Monster2();
        ResType_Monster3();
        ResType_Monster4();
        ResType_Monster5();
        ResType_Monster6();
        ResType_Monster7();
        ResType_Monster8();
        ResType_Monster9();
        ResType_Monster10();
        ResType_Monster11();
        ResType_Monster12();
        ResType_Monster13();
        ResType_Monster14();
        ResType_Monster15();
        ResType_Monster16();
        ResType_Monster17();
        ResType_Monster18();
        ResType_Monster19();
        ResType_Monster20();
        ResType_Monster21();
        ResType_Monster22();
        ResType_Monster23();
        ResType_Monster24();
        ResType_Monster25();
        ResType_Monster26();
        ResType_Monster27();
        ResType_Monster28();
        ResType_Monster29();
        ResType_Monster30();
        ResType_Monster32();
        ResType_Monster33();
        ResType_Monster34();
        ResType_Monster35();
        ResType_Monster36();
        ResType_Monster37();
        ResType_Monster38();
        ResType_Monster39();
        ResType_Monster40();
        ResType_Monster41();
        ResType_Monster42();
        EditorUtility.DisplayDialog("资源重组结束", "所有怪物", "ok");
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第1张怪物资源图")]
    public static void ResType_Monster1()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster1, FrameSet.Monster1);
        ResType_Monster(EnumResType.monster1, FrameSet.Monster2);
        ResType_Monster(EnumResType.monster1, FrameSet.Monster3);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第2张怪物资源图")]
    public static void ResType_Monster2()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster2, FrameSet.Monster4);
        ResType_Monster(EnumResType.monster2, FrameSet.Monster5);
        ResType_Monster(EnumResType.monster2, FrameSet.Monster6);
        ResType_Monster(EnumResType.monster2, FrameSet.Monster7);
        ResType_Monster(EnumResType.monster2, FrameSet.Monster8);
        ResType_Monster(EnumResType.monster2, FrameSet.Monster9);
        ResType_Monster(EnumResType.monster2, FrameSet.Monster10);
        ResType_Monster(EnumResType.monster2, FrameSet.Monster11);
        ResType_Monster(EnumResType.monster2, FrameSet.Monster12);
        ResType_Monster(EnumResType.monster2, FrameSet.Monster13);
        ResType_Monster(EnumResType.monster2, FrameSet.Monster14);
        ResType_Monster(EnumResType.monster2, FrameSet.Monster15);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第3张怪物资源图")]
    public static void ResType_Monster3()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster3, FrameSet.Monster16);
        ResType_Monster(EnumResType.monster3, FrameSet.Monster17);
        ResType_Monster(EnumResType.monster3, FrameSet.Monster18);
        ResType_Monster(EnumResType.monster3, FrameSet.Monster19);
        ResType_Monster(EnumResType.monster3, FrameSet.Monster20);
        ResType_Monster(EnumResType.monster3, FrameSet.Monster21);
        ResType_Monster(EnumResType.monster3, FrameSet.Monster22);
        ResType_Monster(EnumResType.monster3, FrameSet.Monster23);
        ResType_Monster(EnumResType.monster3, FrameSet.Monster24);
        ResType_Monster(EnumResType.monster3, FrameSet.Monster25);
        ResType_Monster(EnumResType.monster3, FrameSet.Monster26);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第4张怪物资源图")]
    public static void ResType_Monster4()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster4, FrameSet.Monster27);
        ResType_Monster(EnumResType.monster4, FrameSet.Monster28);
        ResType_Monster(EnumResType.monster4, FrameSet.Monster29);
        ResType_Monster(EnumResType.monster4, FrameSet.Monster30);
        ResType_Monster(EnumResType.monster4, FrameSet.Monster31);
        ResType_Monster(EnumResType.monster4, FrameSet.Monster32);
        ResType_Monster(EnumResType.monster4, FrameSet.Monster33);
        ResType_Monster(EnumResType.monster4, FrameSet.Monster34);
        ResType_Monster(EnumResType.monster4, FrameSet.Monster35);
        ResType_Monster(EnumResType.monster4, FrameSet.Monster36);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第5张怪物资源图")]
    public static void ResType_Monster5()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster5, FrameSet.Monster37);
        ResType_Monster(EnumResType.monster5, FrameSet.Monster38);
        ResType_Monster(EnumResType.monster5, FrameSet.Monster39);
        ResType_Monster(EnumResType.monster5, FrameSet.Monster40);
        ResType_Monster(EnumResType.monster5, FrameSet.Monster41);
        ResType_Monster(EnumResType.monster5, FrameSet.Monster42);
        ResType_Monster(EnumResType.monster5, FrameSet.Monster43);
        ResType_Monster(EnumResType.monster5, FrameSet.Monster44);
        ResType_Monster(EnumResType.monster5, FrameSet.Monster45);
        ResType_Monster(EnumResType.monster5, FrameSet.Monster46);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第6张怪物资源图")]
    public static void ResType_Monster6()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster6, FrameSet.Monster47);
        ResType_Monster(EnumResType.monster6, FrameSet.Monster48);
        ResType_Monster(EnumResType.monster6, FrameSet.Monster49);
        ResType_Monster(EnumResType.monster6, FrameSet.Monster50);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第7张怪物资源图")]
    public static void ResType_Monster7()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster7, FrameSet.Monster51);
        ResType_Monster(EnumResType.monster7, FrameSet.Monster52);
        ResType_Monster(EnumResType.monster7, FrameSet.Monster53);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第8张怪物资源图")]
    public static void ResType_Monster8()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster8, FrameSet.Monster54);
        ResType_Monster(EnumResType.monster8, FrameSet.Monster55);
        ResType_Monster(EnumResType.monster8, FrameSet.Monster56);
        ResType_Monster(EnumResType.monster8, FrameSet.Monster57);
        ResType_Monster(EnumResType.monster8, FrameSet.Monster58);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第9张怪物资源图")]
    public static void ResType_Monster9()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster9, FrameSet.Monster59);
        ResType_Monster(EnumResType.monster9, FrameSet.Monster60);
        ResType_Monster(EnumResType.monster9, FrameSet.Monster61);
        ResType_Monster(EnumResType.monster9, FrameSet.Monster62);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第10张怪物资源图")]
    public static void ResType_Monster10()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster10, FrameSet.Monster63);
        ResType_Monster(EnumResType.monster10, FrameSet.Monster64);
        ResType_Monster(EnumResType.monster10, FrameSet.Monster65);
        ResType_Monster(EnumResType.monster10, FrameSet.Monster66);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第11张怪物资源图")]
    public static void ResType_Monster11()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster11, FrameSet.Monster63);
        ResType_Monster(EnumResType.monster11, FrameSet.Monster64);
        ResType_Monster(EnumResType.monster11, FrameSet.Monster65);
        ResType_Monster(EnumResType.monster11, FrameSet.Monster66);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第12张怪物资源图")]
    public static void ResType_Monster12()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster12, FrameSet.Monster67);
        ResType_Monster(EnumResType.monster12, FrameSet.Monster68);
        ResType_Monster(EnumResType.monster12, FrameSet.Monster69);
        ResType_Monster(EnumResType.monster12, FrameSet.Monster70);
        ResType_Monster(EnumResType.monster12, FrameSet.Monster71);
        ResType_Monster(EnumResType.monster12, FrameSet.Monster72);
        ResType_Monster(EnumResType.monster12, FrameSet.Monster73);
        ResType_Monster(EnumResType.monster12, FrameSet.Monster74);
        ResType_Monster(EnumResType.monster12, FrameSet.Monster75);
        ResType_Monster(EnumResType.monster12, FrameSet.Monster76);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第13张怪物资源图")]
    public static void ResType_Monster13()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster13, FrameSet.Monster77);
        ResType_Monster(EnumResType.monster13, FrameSet.Monster78);
        ResType_Monster(EnumResType.monster13, FrameSet.Monster79);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第14张怪物资源图")]
    public static void ResType_Monster14()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster14, FrameSet.Monster80);
        ResType_Monster(EnumResType.monster14, FrameSet.Monster81);
        ResType_Monster(EnumResType.monster14, FrameSet.Monster82);
        ResType_Monster(EnumResType.monster14, FrameSet.Monster83);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第15张怪物资源图")]
    public static void ResType_Monster15()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster15, FrameSet.Monster84);
        ResType_Monster(EnumResType.monster15, FrameSet.Monster85);
        ResType_Monster(EnumResType.monster15, FrameSet.Monster86);
        ResType_Monster(EnumResType.monster15, FrameSet.Monster87);
        ResType_Monster(EnumResType.monster15, FrameSet.Monster88);
        ResType_Monster(EnumResType.monster15, FrameSet.Monster89);
        ResType_Monster(EnumResType.monster15, FrameSet.Monster90);
        ResType_Monster(EnumResType.monster15, FrameSet.Monster91);
        ResType_Monster(EnumResType.monster15, FrameSet.Monster92);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第16张怪物资源图")]
    public static void ResType_Monster16()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster16, FrameSet.Monster93);
        ResType_Monster(EnumResType.monster16, FrameSet.Monster94);
        ResType_Monster(EnumResType.monster16, FrameSet.Monster95);
        ResType_Monster(EnumResType.monster16, FrameSet.Monster96);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第17张怪物资源图")]
    public static void ResType_Monster17()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster17, FrameSet.Monster97);
        ResType_Monster(EnumResType.monster17, FrameSet.Monster98);
        ResType_Monster(EnumResType.monster17, FrameSet.Monster99);
        ResType_Monster(EnumResType.monster17, FrameSet.Monster100);
        ResType_Monster(EnumResType.monster17, FrameSet.Monster101);
        ResType_Monster(EnumResType.monster17, FrameSet.Monster102);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第18张怪物资源图")]
    public static void ResType_Monster18()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster18, FrameSet.Monster103);
        ResType_Monster(EnumResType.monster18, FrameSet.Monster104);
        ResType_Monster(EnumResType.monster18, FrameSet.Monster105);
        ResType_Monster(EnumResType.monster18, FrameSet.Monster106);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第19张怪物资源图")]
    public static void ResType_Monster19()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster19, FrameSet.Monster107);
        ResType_Monster(EnumResType.monster19, FrameSet.Monster108);
        ResType_Monster(EnumResType.monster19, FrameSet.Monster109);
        ResType_Monster(EnumResType.monster19, FrameSet.Monster110);
        ResType_Monster(EnumResType.monster19, FrameSet.Monster111);
        ResType_Monster(EnumResType.monster19, FrameSet.Monster112);
        ResType_Monster(EnumResType.monster19, FrameSet.Monster113);
        ResType_Monster(EnumResType.monster19, FrameSet.Monster114);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第20张怪物资源图")]
    public static void ResType_Monster20()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster20, FrameSet.Monster115);
        ResType_Monster(EnumResType.monster20, FrameSet.Monster116);
        ResType_Monster(EnumResType.monster20, FrameSet.Monster117);
        ResType_Monster(EnumResType.monster20, FrameSet.Monster118);
        ResType_Monster(EnumResType.monster20, FrameSet.Monster119);
        ResType_Monster(EnumResType.monster20, FrameSet.Monster120);
        ResType_Monster(EnumResType.monster20, FrameSet.Monster121);
    }


    [MenuItem("Tools/热血传奇怀旧/Monster/第21张怪物资源图")]
    public static void ResType_Monster21()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster21, FrameSet.Monster122);
        ResType_Monster(EnumResType.monster21, FrameSet.Monster123);
        ResType_Monster(EnumResType.monster21, FrameSet.Monster124);
        ResType_Monster(EnumResType.monster21, FrameSet.Monster125);
        ResType_Monster(EnumResType.monster21, FrameSet.Monster126);
        ResType_Monster(EnumResType.monster21, FrameSet.Monster127);
        ResType_Monster(EnumResType.monster21, FrameSet.Monster128);
        ResType_Monster(EnumResType.monster21, FrameSet.Monster129);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第22张怪物资源图")]
    public static void ResType_Monster22()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster22, FrameSet.Monster130);
        ResType_Monster(EnumResType.monster22, FrameSet.Monster131);
        ResType_Monster(EnumResType.monster22, FrameSet.Monster132);
        ResType_Monster(EnumResType.monster22, FrameSet.Monster133);
        ResType_Monster(EnumResType.monster22, FrameSet.Monster134);
        ResType_Monster(EnumResType.monster22, FrameSet.Monster135);
        ResType_Monster(EnumResType.monster22, FrameSet.Monster136);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第23张怪物资源图")]
    public static void ResType_Monster23()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster23, FrameSet.Monster137);
        ResType_Monster(EnumResType.monster23, FrameSet.Monster138);
        ResType_Monster(EnumResType.monster23, FrameSet.Monster139);
        ResType_Monster(EnumResType.monster23, FrameSet.Monster140);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第24张怪物资源图")]
    public static void ResType_Monster24()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster24, FrameSet.Monster141);
        ResType_Monster(EnumResType.monster24, FrameSet.Monster142);
        ResType_Monster(EnumResType.monster24, FrameSet.Monster143);
        ResType_Monster(EnumResType.monster24, FrameSet.Monster144);
        ResType_Monster(EnumResType.monster24, FrameSet.Monster145);
        ResType_Monster(EnumResType.monster24, FrameSet.Monster146);
        ResType_Monster(EnumResType.monster24, FrameSet.Monster147);
        ResType_Monster(EnumResType.monster24, FrameSet.Monster148);
        ResType_Monster(EnumResType.monster24, FrameSet.Monster149);
        ResType_Monster(EnumResType.monster24, FrameSet.Monster150);
        ResType_Monster(EnumResType.monster24, FrameSet.Monster151);
        ResType_Monster(EnumResType.monster24, FrameSet.Monster152);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第25张怪物资源图")]
    public static void ResType_Monster25()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster25, FrameSet.Monster153);
        ResType_Monster(EnumResType.monster25, FrameSet.Monster154);
        ResType_Monster(EnumResType.monster25, FrameSet.Monster155);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第26张怪物资源图")]
    public static void ResType_Monster26()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster26, FrameSet.Monster156);
        ResType_Monster(EnumResType.monster26, FrameSet.Monster157);
        ResType_Monster(EnumResType.monster26, FrameSet.Monster158);
        ResType_Monster(EnumResType.monster26, FrameSet.Monster159);
        ResType_Monster(EnumResType.monster26, FrameSet.Monster160);
        ResType_Monster(EnumResType.monster26, FrameSet.Monster161);
        ResType_Monster(EnumResType.monster26, FrameSet.Monster162);
        ResType_Monster(EnumResType.monster26, FrameSet.Monster163);
        ResType_Monster(EnumResType.monster26, FrameSet.Monster164);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第27张怪物资源图")]
    public static void ResType_Monster27()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster27, FrameSet.Monster165);
        ResType_Monster(EnumResType.monster27, FrameSet.Monster166);
        ResType_Monster(EnumResType.monster27, FrameSet.Monster167);
        ResType_Monster(EnumResType.monster27, FrameSet.Monster168);
        ResType_Monster(EnumResType.monster27, FrameSet.Monster169);
        ResType_Monster(EnumResType.monster27, FrameSet.Monster170);
        ResType_Monster(EnumResType.monster27, FrameSet.Monster171);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第28张怪物资源图")]
    public static void ResType_Monster28()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster28, FrameSet.Monster172);
        ResType_Monster(EnumResType.monster28, FrameSet.Monster173);
        ResType_Monster(EnumResType.monster28, FrameSet.Monster174);
        ResType_Monster(EnumResType.monster28, FrameSet.Monster175);
        ResType_Monster(EnumResType.monster28, FrameSet.Monster176);
        ResType_Monster(EnumResType.monster28, FrameSet.Monster177);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第29张怪物资源图")]
    public static void ResType_Monster29()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster29, FrameSet.Monster178);
        ResType_Monster(EnumResType.monster29, FrameSet.Monster179);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第30张怪物资源图")]
    public static void ResType_Monster30()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster30, FrameSet.Monster180);
        ResType_Monster(EnumResType.monster30, FrameSet.Monster181);
        ResType_Monster(EnumResType.monster30, FrameSet.Monster182);
        ResType_Monster(EnumResType.monster30, FrameSet.Monster183);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第32张怪物资源图")]
    public static void ResType_Monster32()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster32, FrameSet.Monster184);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster185);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster186);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster187);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster188);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster189);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster190);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster191);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster192);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster193);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster194);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster195);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster196);
        ResType_Monster(EnumResType.monster32, FrameSet.Monster197);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第33张怪物资源图")]
    public static void ResType_Monster33()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster33, FrameSet.Monster198);
        ResType_Monster(EnumResType.monster33, FrameSet.Monster199);
        ResType_Monster(EnumResType.monster33, FrameSet.Monster200);
        ResType_Monster(EnumResType.monster33, FrameSet.Monster201);
        ResType_Monster(EnumResType.monster33, FrameSet.Monster202);
        ResType_Monster(EnumResType.monster33, FrameSet.Monster203);
        ResType_Monster(EnumResType.monster33, FrameSet.Monster204);
        ResType_Monster(EnumResType.monster33, FrameSet.Monster205);
        ResType_Monster(EnumResType.monster33, FrameSet.Monster206);
        ResType_Monster(EnumResType.monster33, FrameSet.Monster207);
        ResType_Monster(EnumResType.monster33, FrameSet.Monster208);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第34张怪物资源图")]
    public static void ResType_Monster34()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster34, FrameSet.Monster209);
        ResType_Monster(EnumResType.monster34, FrameSet.Monster210);
        ResType_Monster(EnumResType.monster34, FrameSet.Monster211);
        ResType_Monster(EnumResType.monster34, FrameSet.Monster212);
        ResType_Monster(EnumResType.monster34, FrameSet.Monster213);
        ResType_Monster(EnumResType.monster34, FrameSet.Monster214);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第35张怪物资源图")]
    public static void ResType_Monster35()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster35, FrameSet.Monster215);
        ResType_Monster(EnumResType.monster35, FrameSet.Monster216);
        ResType_Monster(EnumResType.monster35, FrameSet.Monster217);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第36张怪物资源图")]
    public static void ResType_Monster36()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster36, FrameSet.Monster218);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster219);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster220);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster221);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster222);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster223);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster224);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster225);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster226);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster227);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster228);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster229);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster230);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster231);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster232);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster233);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster234);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster235);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster236);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster237);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster238);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster239);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster240);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster241);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster242);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster243);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster244);
        ResType_Monster(EnumResType.monster36, FrameSet.Monster245);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第37张怪物资源图")]
    public static void ResType_Monster37()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster37, FrameSet.Monster246);
        ResType_Monster(EnumResType.monster37, FrameSet.Monster247);
        ResType_Monster(EnumResType.monster37, FrameSet.Monster248);
        ResType_Monster(EnumResType.monster37, FrameSet.Monster249);
        ResType_Monster(EnumResType.monster37, FrameSet.Monster250);
        ResType_Monster(EnumResType.monster37, FrameSet.Monster251);
        ResType_Monster(EnumResType.monster37, FrameSet.Monster252);
        ResType_Monster(EnumResType.monster37, FrameSet.Monster253);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第38张怪物资源图")]
    public static void ResType_Monster38()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster38, FrameSet.Monster184);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster185);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster186);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster187);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster188);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster189);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster190);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster191);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster192);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster193);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster194);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster195);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster196);
        ResType_Monster(EnumResType.monster38, FrameSet.Monster197);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第39张怪物资源图")]
    public static void ResType_Monster39()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster39, FrameSet.Monster254);
        ResType_Monster(EnumResType.monster39, FrameSet.Monster255);
        ResType_Monster(EnumResType.monster39, FrameSet.Monster256);
        ResType_Monster(EnumResType.monster39, FrameSet.Monster257);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第40张怪物资源图")]
    public static void ResType_Monster40()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster40, FrameSet.Monster258);
        ResType_Monster(EnumResType.monster40, FrameSet.Monster259);
        ResType_Monster(EnumResType.monster40, FrameSet.Monster260);
        ResType_Monster(EnumResType.monster40, FrameSet.Monster261);
        ResType_Monster(EnumResType.monster40, FrameSet.Monster262);
        ResType_Monster(EnumResType.monster40, FrameSet.Monster263);
        ResType_Monster(EnumResType.monster40, FrameSet.Monster264);
        ResType_Monster(EnumResType.monster40, FrameSet.Monster265);
    }

    [MenuItem("Tools/热血传奇怀旧/Monster/第41张怪物资源图")]
    public static void ResType_Monster41()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster41, FrameSet.Monster266);
        ResType_Monster(EnumResType.monster41, FrameSet.Monster267);
        ResType_Monster(EnumResType.monster41, FrameSet.Monster268);
    }


    [MenuItem("Tools/热血传奇怀旧/Monster/第42张怪物资源图")]
    public static void ResType_Monster42()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster42, FrameSet.Monster269);
        ResType_Monster(EnumResType.monster42, FrameSet.Monster270);
        ResType_Monster(EnumResType.monster42, FrameSet.Monster271);
    }
    #endregion

    #region Effect
    [MenuItem("Tools/热血传奇怀旧/Effect/资源重组-所有特效资源")]
    public static void ResType_AllEffect()
    {
        string beginTime = System.DateTime.Now.ToString();
        ResType_Effect();
        ResType_Effect1();
        ResType_Effect2();
        ResType_Effect3();
        ResType_Effect4();
        ResType_Effect5();
        ResType_Effect6();
        ResType_Effect7();
        ResType_Effect8();
        ResType_Effect9();
        ResType_Effect10();
        ResType_Effect11();
        string endTime = System.DateTime.Now.ToString();
        EditorUtility.DisplayDialog("资源重组结束", string.Format("开始时间{0}, 结束时间:{1}", beginTime, endTime), "ok");
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第1组特效资源")]
    public static void ResType_Effect()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect, FrameSet.Effect);
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第2组特效资源")]
    public static void ResType_Effect1()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect1, FrameSet.Effect1);
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第3组特效资源")]
    public static void ResType_Effect2()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect2, FrameSet.Effect2);
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第4组特效资源")]
    public static void ResType_Effect3()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect3, FrameSet.Effect3);
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第5组特效资源")]
    public static void ResType_Effect4()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect4, FrameSet.Effect4);
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第6组特效资源")]
    public static void ResType_Effect5()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect5, FrameSet.Effect5);
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第7组特效资源")]
    public static void ResType_Effect6()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect6, FrameSet.Effect6);
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第8组特效资源")]
    public static void ResType_Effect7()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect7, FrameSet.Effect7);
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第9组特效资源")]
    public static void ResType_Effect8()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect8, FrameSet.Effect8);
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第10组特效资源")]
    public static void ResType_Effect9()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect9, FrameSet.Effect9);
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第11组特效资源")]
    public static void ResType_Effect10()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect10, FrameSet.Effect10);
    }

    [MenuItem("Tools/热血传奇怀旧/Effect/第12组特效资源")]
    public static void ResType_Effect11()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect11, FrameSet.Effect11);
    }

    #endregion

    public static void UIBmpToPng(EnumResType enumResType)
    {
        if (!sourcePaths_Type.ContainsKey(enumResType))
        {
            Debug.LogError("先配置搜索路径, Res Type = " + enumResType.ToString());
            return;
        }

        float pathIndex = 0;
        List<string> paths = sourcePaths_Type[enumResType];
        foreach (string sourcePath in paths)
        {
            int maxCount = Utils.FindFiles(sourcePath, "*.bmp").Count;
            string pngParentPath = outPngParentPath + @"ui\" + Path.GetFileNameWithoutExtension(sourcePath) + @"\";

            if (!Directory.Exists(pngParentPath))
                Directory.CreateDirectory(pngParentPath);

            float resIndex = 0;
            List<string> filePaths = Utils.FindFiles(sourcePath, "*.bmp");
            foreach (string filePath in filePaths)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string pngPath = pngParentPath + fileName + @".png";

                if (!File.Exists(pngPath))
                {
                    BmpData bmpData = new BmpData();
                    bmpData.bmpPath = filePath;
                    bmpData.pngPath = pngPath;
                    BmpToPng.BmpToPngUI(bmpData);
                }

                EditorUtility.DisplayProgressBar(enumResType.ToString() + "资源重组" + string.Format("{0} - {1}, {2}/{3}", pathIndex, paths.Count, resIndex, maxCount),
                          Path.GetFullPath(pngPath), resIndex / (float)maxCount);
                resIndex++;
            }

            pathIndex++;
        }

        EditorUtility.ClearProgressBar();
    }

    public static void ResType(EnumResType enumResType)
    {
        if(!sourcePaths_Type.ContainsKey(enumResType))
        {
            Debug.LogError("先配置搜索路径, Res Type = " + enumResType.ToString());
            return;
        }

        int pathIndex = 1;
        List<string> paths = sourcePaths_Type[enumResType];
        foreach (string sourcePath in paths)
        {            
            int maxCount = Utils.FindFiles(sourcePath, "*.bmp").Count;

            Dictionary<MirAction, Frame> playerFrames = FrameSet.Players.Frames;

            bool alpha = false;
            float alphaSize = 0;
            float addColor = 0;

            if (enumResType == EnumResType.wing)
            {
                alpha = true;
                alphaSize = 0.9f;
                addColor = 5;
                playerFrames = FrameSet.Wings.Frames;
            }

            int resMaxFrame = FrameSet.Players.resMaxFrame;
            if (enumResType == EnumResType.wing)
                resMaxFrame = FrameSet.Wings.resMaxFrame;

            int resIndex = 0;
            bool gender = false; //0男 1女
            int maleResId = 1000;
            int femaleRedId = 999;
            int startFrameIndex = 0;
            string genderFileName = "";
            bool end = false;

            if (enumResType == EnumResType.hair)
            {
                gender = true;
            }
            else
            {
                gender = false;
            }

            BmpData bmpData = new BmpData();

            while (!end)
            {
                string resType = Path.GetFileNameWithoutExtension(sourcePath) + @"\";
                genderFileName = genderFileNames[gender] + @"\";

                foreach (var value in playerFrames)
                {
                    int genderResId = gender == true ? femaleRedId : maleResId;

                    string actionName = eToc[value.Key];
                    string outPngParentPath = ResTypeTools.outPngParentPath + resType + genderFileName + genderResId + @"\" + actionName + @"\";

                    if (!Directory.Exists(outPngParentPath))
                        Directory.CreateDirectory(outPngParentPath);

                    Frame frame = value.Value;
                    for (byte Direction = (byte)MirDirection.Up; Direction <= (byte)MirDirection.UpLeft; Direction++)
                    {
                        int actionIndex = 10000 * (Direction + 1);
                        for (int FrameIndex = 0; FrameIndex < frame.Count; FrameIndex++)
                        {
                            resIndex++;

                            int Frame = frame.Start + (frame.OffSet * Direction) + FrameIndex + startFrameIndex;
                            string bmpFilePath = sourcePath + @"\" + Frame + @".bmp";
                            string offsetPath = sourcePath + @"\Placements\" + Frame + @".txt";

                            if (!File.Exists(bmpFilePath))
                            {
                                end = true;
                                break;
                            }

                            string pngPath = outPngParentPath + actionIndex + @".png";

                            if (!File.Exists(pngPath))
                            {
                                bmpData.bmpPath = bmpFilePath;
                                bmpData.pngPath = pngPath;
                                bmpData.offsetPath = offsetPath;
                                bmpData.effectAlpha = alpha;
                                bmpData.effectAlphaSize = alphaSize;
                                bmpData.effectAddColor = addColor;
                                BmpToPng.BmpToPngAction(bmpData);
                            }

                            actionIndex++;
                            EditorUtility.DisplayProgressBar(enumResType.ToString() + "资源重组" + string.Format("{0} - {1}, {2}/{3}", pathIndex, paths.Count, resIndex, maxCount),
                                Path.GetFullPath(pngPath), resIndex / (float)maxCount);
                        }

                        if (end)
                            break;
                    }

                    if (end)
                        break;
                }

                gender = !gender;
                if (gender)
                {
                    femaleRedId++;
                }
                else
                {
                    maleResId++;
                }

                startFrameIndex += resMaxFrame;
                //#region 测试代码
                //EditorUtility.ClearProgressBar();
                //break;
                //#endregion
            }

            pathIndex++;
        }
        
        EditorUtility.ClearProgressBar();
    }

    public static void ResType_Monster(EnumResType enumResType, FrameSet frameSet)
    {
        if (!sourcePaths_Type.ContainsKey(enumResType))
        {
            Debug.LogError("先配置搜索路径, Res Type = " + enumResType.ToString());
            return;
        }

        Dictionary<MirAction, Frame> frames = frameSet.Frames;
        float alphaSize = 0.9f;
        float addColor = 10;

        int pathIndex = 1;
        List<string> paths = sourcePaths_Type[enumResType];
        foreach (string sourcePath in paths)
        {
            int maxCount = Utils.FindFiles(sourcePath, "*.bmp").Count;
            BmpData bmpData = new BmpData();

            string resType = Path.GetFileNameWithoutExtension(sourcePath) + @"\";

            foreach (var value in frames)
            {
                string actionName = eToc[value.Key];
                string outPngParentPath = ResTypeTools.outPngParentPath + @"monster\" + resType + monsterResType + @"\" + actionName + @"\";

                if (!Directory.Exists(outPngParentPath))
                    Directory.CreateDirectory(outPngParentPath);

                int frameCount = 0;
                Frame frame = value.Value;
                for (byte Direction = (byte)MirDirection.Up; Direction <= (byte)MirDirection.UpLeft; Direction++)
                {
                    int actionIndex = 10000 * (Direction + 1);
                    for (int FrameIndex = 0; FrameIndex < frame.Count; FrameIndex++)
                    {
                        monsterResIndex++;

                        int Frame = frame.Start + (frame.OffSet * Direction) + FrameIndex;
                        string bmpFilePath = sourcePath + @"\" + Frame + @".bmp";
                        string offsetPath = sourcePath + @"\Placements\" + Frame + @".txt";

                        string pngPath = outPngParentPath + actionIndex + @".png";

                        if ((!File.Exists(pngPath)/* || frame.EffectAlpha || frame.Alpha*/) && File.Exists(bmpFilePath))
                        {
                            bmpData.bmpPath = bmpFilePath;
                            bmpData.pngPath = pngPath;
                            bmpData.offsetPath = offsetPath;
                            bmpData.effectAlpha = frame.EffectAlpha;
                            bmpData.effectAlphaSize = alphaSize;
                            bmpData.effectAddColor = addColor;

                            bmpData.alpha = frame.Alpha;
                            bmpData.alphaSize = alphaSize;
                            bmpData.addColor = addColor;
                            BmpToPng.BmpToPngAction(bmpData);
                        }

                        frameCount++;
                        actionIndex++;
                        EditorUtility.DisplayProgressBar(enumResType.ToString() + "资源重组" + string.Format("{0} - {1}, {2}/{3}", pathIndex, paths.Count, monsterResIndex, maxCount),
                            Path.GetFullPath(pngPath), monsterResIndex / (float)maxCount);
                    }

                    if (frameCount >= frame.MaxCount)
                        break;
                }
            }

            pathIndex++;
        }

        monsterResType++;
        EditorUtility.ClearProgressBar();
    }

    public static void ResType_Effect(EnumResType enumResType, FrameSet frameSet)
    {
        if (!sourcePaths_Type.ContainsKey(enumResType))
        {
            Debug.LogError("先配置搜索路径, Res Type = " + enumResType.ToString());
            return;
        }

        List<Frame> frames = frameSet.EffectFrames;
        float alphaSize = 1.2f;
        float addColor = 5;

        int pathIndex = 1;
        List<string> paths = sourcePaths_Type[enumResType];
        foreach (string sourcePath in paths)
        {
            int maxCount = Utils.FindFiles(sourcePath, "*.bmp").Count;
            BmpData bmpData = new BmpData();

            string resType = Path.GetFileNameWithoutExtension(sourcePath) + @"\";

            int effectIndex = 1000;
            foreach (var value in frames)
            {
                string actionName = effectIndex.ToString();
                string outPngParentPath = ResTypeTools.outPngParentPath + @"effect\" + resType + @"\" + actionName + @"\";

                if (!Directory.Exists(outPngParentPath))
                    Directory.CreateDirectory(outPngParentPath);

                int frameCount = 0;
                Frame frame = value;
                for (byte Direction = (byte)MirDirection.Up; Direction <= (byte)MirDirection.UpLeft; Direction++)
                {
                    int actionIndex = 10000 * (Direction + 1);
                    for (int FrameIndex = 0; FrameIndex < frame.Count; FrameIndex++)
                    {
                        monsterResIndex++;

                        int Frame = frame.Start + (frame.OffSet * Direction) + FrameIndex;
                        string bmpFilePath = sourcePath + @"\" + Frame + @".bmp";
                        string offsetPath = sourcePath + @"\Placements\" + Frame + @".txt";

                        string pngPath = outPngParentPath + actionIndex + @".png";

                        if (!File.Exists(pngPath) && File.Exists(bmpFilePath))
                        {
                            bmpData.bmpPath = bmpFilePath;
                            bmpData.pngPath = pngPath;
                            bmpData.offsetPath = offsetPath;
                            bmpData.effectAlpha = frame.EffectAlpha;
                            bmpData.effectAlphaSize = alphaSize;
                            bmpData.effectAddColor = addColor;

                            BmpToPng.BmpToPngAction(bmpData);
                        }

                        frameCount++;
                        actionIndex++;
                        EditorUtility.DisplayProgressBar(enumResType.ToString() + "资源重组" + string.Format("{0} - {1}, {2}/{3}", pathIndex, paths.Count, monsterResIndex, maxCount),
                            Path.GetFullPath(pngPath), monsterResIndex / (float)maxCount);
                    }

                    if (frameCount >= frame.MaxCount)
                        break;
                }

                effectIndex++;
            }

            pathIndex++;
        }

        effectResType++;
        EditorUtility.ClearProgressBar();
    }

    public static void Rename(string sourcePath)
    {
        List<string> pointPaths = Utils.FindFiles(sourcePath, "*.txt");

        int index = 0;
        foreach (string path in pointPaths)
        {
            string fileName = Path.GetFileNameWithoutExtension(path);

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            string txtParentPath = directoryInfo.Parent.FullName;
            string txtPath = txtParentPath + @"\" + index + @".txt";

            if (!File.Exists(txtPath))
                File.Move(path, txtPath);

            string bmpParentPath = directoryInfo.Parent.Parent.FullName;
            string bmpPath = bmpParentPath + @"\" + fileName + @".bmp";
            string newBmpPath = bmpParentPath + @"\" + index + @".bmp";

            if (!File.Exists(newBmpPath))
                File.Move(bmpPath, newBmpPath);

            EditorUtility.DisplayProgressBar("重命名", path, index / (float)pointPaths.Count);
            index++;
        }

        EditorUtility.ClearProgressBar();
    }
}
