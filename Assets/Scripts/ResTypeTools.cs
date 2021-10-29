using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public enum EnumResType
{
    all,      //����
    player,   //��ɫ
    hair,     //ͷ��
    weapon,   //����
    bmpToPng, //bmpתpng
    wing,     //��򵼳�
    ui,       //ui����
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
    monster1,  //����
    monster2,  //����1
    monster3,  //����2
    monster4,  //����3
    monster5,  //����4
    monster6,  //����5
    monster7,  //����6
    monster8,  //����7
    monster9,  //����8
    monster10,  //����9
    monster11,  //����10
    monster12,  //����11
    monster13,  //����12
    monster14,  //����13
    monster15,  //����14
    monster16,  //����15
    monster17,  //����16
    monster18,  //����17
    monster19,  //����18
    monster20,  //����19
    monster21,  //����20
    monster22,  //����21
    monster23,  //����22
    monster24,  //����23
    monster25,  //����24
    monster26,  //����25
    monster27,  //����26
    monster28,  //����27
    monster29,  //����28
    monster30,  //����29
    monster31,  //����30
    monster32,  //����31
    monster33,  //����32
    monster34,  //����33
    monster35,  //����34
    monster36,  //����35
    monster37,  //����36
    monster38,  //����37
    monster39,  //����38
    monster40,  //����39
    monster41,  //����40
    monster42,  //����41
}

public class ResTypeTools
{
    private static string rootPath = Application.dataPath + @"\..\";
    private static string ssdRootPath = @"E:\";
    private static int monsterResType = 1000;
    private static int effectResType = 10000;
    private static int monsterResIndex = 0;

    //ɾ������ͼ�Ϳ��ı�·��
    private static List<string> sourcePaths = new List<string>
    {
        #region ����
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

        #region ����
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
        [false] = "��ģ", [true] = "Ůģ"
    };

    private static Dictionary<MirAction, string> eToc = new Dictionary<MirAction, string>
    {
        [MirAction.ShiFa] = "ʩ��",
        [MirAction.Attack1] = "����",
        [MirAction.Attack2] = "����1",
        [MirAction.Attack3] = "����2",
        [MirAction.Attack4] = "����3",
        [MirAction.Attack5] = "����4",
        [MirAction.BeiJi] = "����",

        [MirAction.BeiZhan] = "��ս",
        [MirAction.Die] = "����",
        [MirAction.Die1] = "����1",
        [MirAction.Running] = "�ܲ�",
        [MirAction.ShiQu] = "ʰȡ",
        [MirAction.Standing] = "����",
        [MirAction.Walking] = "��·",
        [MirAction.Skill] = "����",
        [MirAction.Skill1] = "����1",
        [MirAction.Skill2] = "����2",
        [MirAction.Skill3] = "����3",
        [MirAction.Skill4] = "����4",
        [MirAction.Skill5] = "����5",
        [MirAction.Skill6] = "����6",
        [MirAction.Skill7] = "����7",
        [MirAction.Standing1] = "����1",
        [MirAction.Standing2] = "����2",
        [MirAction.Weapon1] = "����",
        [MirAction.Weapon2] = "����1",
        [MirAction.BianShen] = "����",
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

        //�����ɫ��Դ
        [EnumResType.player] = new List<string> 
        {
            ssdRootPath + @"RXCQ\bmp\Hum",
            ssdRootPath + @"RXCQ\bmp\hum2",
            ssdRootPath + @"RXCQ\bmp\hum3",
        },

        //����ͷ����Դ
        [EnumResType.hair] = new List<string> 
        {
            ssdRootPath + @"RXCQ\bmp\hair2",
        },

        //����������Դ
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

    [MenuItem("Tools/��Ѫ���滳��/������")]
    public static void RenameTools()
    {
        foreach (string sourcePath in sourcePaths)
        {
            Rename(sourcePath);
        }
    }

    [MenuItem("Tools/��Ѫ���滳��/ɾ���հ�ͼƬ")]
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

                EditorUtility.DisplayProgressBar("ɾ���հ�ͼƬ" + string.Format("{0} - {1}, {2}/{3}", pathIndex, sourcePaths.Count, index, pointPaths.Count), pointPath, index / (float)pointPaths.Count);
            }

            pathIndex++;
            EditorUtility.ClearProgressBar();
            Rename(sourcePath);
        }
    }

    [MenuItem("Tools/��Ѫ���滳��/Player/��Դ����-(ͷ�Σ���������ɫ)")]
    public static void ResType_All()
    {
        ResType(EnumResType.all);
    }

    [MenuItem("Tools/��Ѫ���滳��/Player/��Դ����-ͷ��")]
    public static void ResType_Hair()
    {
        ResType(EnumResType.hair);
    }

    [MenuItem("Tools/��Ѫ���滳��/Player/��Դ����-����")]
    public static void ResType_Weapon()
    {
        ResType(EnumResType.weapon);
    }

    [MenuItem("Tools/��Ѫ���滳��/Player/��Դ����-��ɫ")]
    public static void ResType_Player()
    {
        ResType(EnumResType.player);
    }

    [MenuItem("Tools/��Ѫ���滳��/Player/��Դ����-���")]
    public static void ResType_Wing()
    {
        ResType(EnumResType.wing);
    }

    [MenuItem("Tools/��Ѫ���滳��/UI/��Դ����-ui")]
    public static void ResType_UI()
    {
        UIBmpToPng(EnumResType.ui);
    }

    #region Monster
    [MenuItem("Tools/��Ѫ���滳��/Monster/��Դ����-���й���")]
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
        EditorUtility.DisplayDialog("��Դ�������", "���й���", "ok");
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��1�Ź�����Դͼ")]
    public static void ResType_Monster1()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster1, FrameSet.Monster1);
        ResType_Monster(EnumResType.monster1, FrameSet.Monster2);
        ResType_Monster(EnumResType.monster1, FrameSet.Monster3);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��2�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��3�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��4�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��5�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��6�Ź�����Դͼ")]
    public static void ResType_Monster6()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster6, FrameSet.Monster47);
        ResType_Monster(EnumResType.monster6, FrameSet.Monster48);
        ResType_Monster(EnumResType.monster6, FrameSet.Monster49);
        ResType_Monster(EnumResType.monster6, FrameSet.Monster50);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��7�Ź�����Դͼ")]
    public static void ResType_Monster7()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster7, FrameSet.Monster51);
        ResType_Monster(EnumResType.monster7, FrameSet.Monster52);
        ResType_Monster(EnumResType.monster7, FrameSet.Monster53);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��8�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��9�Ź�����Դͼ")]
    public static void ResType_Monster9()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster9, FrameSet.Monster59);
        ResType_Monster(EnumResType.monster9, FrameSet.Monster60);
        ResType_Monster(EnumResType.monster9, FrameSet.Monster61);
        ResType_Monster(EnumResType.monster9, FrameSet.Monster62);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��10�Ź�����Դͼ")]
    public static void ResType_Monster10()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster10, FrameSet.Monster63);
        ResType_Monster(EnumResType.monster10, FrameSet.Monster64);
        ResType_Monster(EnumResType.monster10, FrameSet.Monster65);
        ResType_Monster(EnumResType.monster10, FrameSet.Monster66);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��11�Ź�����Դͼ")]
    public static void ResType_Monster11()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster11, FrameSet.Monster63);
        ResType_Monster(EnumResType.monster11, FrameSet.Monster64);
        ResType_Monster(EnumResType.monster11, FrameSet.Monster65);
        ResType_Monster(EnumResType.monster11, FrameSet.Monster66);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��12�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��13�Ź�����Դͼ")]
    public static void ResType_Monster13()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster13, FrameSet.Monster77);
        ResType_Monster(EnumResType.monster13, FrameSet.Monster78);
        ResType_Monster(EnumResType.monster13, FrameSet.Monster79);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��14�Ź�����Դͼ")]
    public static void ResType_Monster14()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster14, FrameSet.Monster80);
        ResType_Monster(EnumResType.monster14, FrameSet.Monster81);
        ResType_Monster(EnumResType.monster14, FrameSet.Monster82);
        ResType_Monster(EnumResType.monster14, FrameSet.Monster83);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��15�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��16�Ź�����Դͼ")]
    public static void ResType_Monster16()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster16, FrameSet.Monster93);
        ResType_Monster(EnumResType.monster16, FrameSet.Monster94);
        ResType_Monster(EnumResType.monster16, FrameSet.Monster95);
        ResType_Monster(EnumResType.monster16, FrameSet.Monster96);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��17�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��18�Ź�����Դͼ")]
    public static void ResType_Monster18()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster18, FrameSet.Monster103);
        ResType_Monster(EnumResType.monster18, FrameSet.Monster104);
        ResType_Monster(EnumResType.monster18, FrameSet.Monster105);
        ResType_Monster(EnumResType.monster18, FrameSet.Monster106);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��19�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��20�Ź�����Դͼ")]
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


    [MenuItem("Tools/��Ѫ���滳��/Monster/��21�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��22�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��23�Ź�����Դͼ")]
    public static void ResType_Monster23()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster23, FrameSet.Monster137);
        ResType_Monster(EnumResType.monster23, FrameSet.Monster138);
        ResType_Monster(EnumResType.monster23, FrameSet.Monster139);
        ResType_Monster(EnumResType.monster23, FrameSet.Monster140);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��24�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��25�Ź�����Դͼ")]
    public static void ResType_Monster25()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster25, FrameSet.Monster153);
        ResType_Monster(EnumResType.monster25, FrameSet.Monster154);
        ResType_Monster(EnumResType.monster25, FrameSet.Monster155);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��26�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��27�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��28�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��29�Ź�����Դͼ")]
    public static void ResType_Monster29()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster29, FrameSet.Monster178);
        ResType_Monster(EnumResType.monster29, FrameSet.Monster179);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��30�Ź�����Դͼ")]
    public static void ResType_Monster30()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster30, FrameSet.Monster180);
        ResType_Monster(EnumResType.monster30, FrameSet.Monster181);
        ResType_Monster(EnumResType.monster30, FrameSet.Monster182);
        ResType_Monster(EnumResType.monster30, FrameSet.Monster183);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��32�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��33�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��34�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��35�Ź�����Դͼ")]
    public static void ResType_Monster35()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster35, FrameSet.Monster215);
        ResType_Monster(EnumResType.monster35, FrameSet.Monster216);
        ResType_Monster(EnumResType.monster35, FrameSet.Monster217);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��36�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��37�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��38�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��39�Ź�����Դͼ")]
    public static void ResType_Monster39()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster39, FrameSet.Monster254);
        ResType_Monster(EnumResType.monster39, FrameSet.Monster255);
        ResType_Monster(EnumResType.monster39, FrameSet.Monster256);
        ResType_Monster(EnumResType.monster39, FrameSet.Monster257);
    }

    [MenuItem("Tools/��Ѫ���滳��/Monster/��40�Ź�����Դͼ")]
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

    [MenuItem("Tools/��Ѫ���滳��/Monster/��41�Ź�����Դͼ")]
    public static void ResType_Monster41()
    {
        monsterResIndex = 0;
        monsterResType = 1000;
        ResType_Monster(EnumResType.monster41, FrameSet.Monster266);
        ResType_Monster(EnumResType.monster41, FrameSet.Monster267);
        ResType_Monster(EnumResType.monster41, FrameSet.Monster268);
    }


    [MenuItem("Tools/��Ѫ���滳��/Monster/��42�Ź�����Դͼ")]
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
    [MenuItem("Tools/��Ѫ���滳��/Effect/��Դ����-������Ч��Դ")]
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
        EditorUtility.DisplayDialog("��Դ�������", string.Format("��ʼʱ��{0}, ����ʱ��:{1}", beginTime, endTime), "ok");
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��1����Ч��Դ")]
    public static void ResType_Effect()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect, FrameSet.Effect);
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��2����Ч��Դ")]
    public static void ResType_Effect1()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect1, FrameSet.Effect1);
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��3����Ч��Դ")]
    public static void ResType_Effect2()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect2, FrameSet.Effect2);
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��4����Ч��Դ")]
    public static void ResType_Effect3()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect3, FrameSet.Effect3);
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��5����Ч��Դ")]
    public static void ResType_Effect4()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect4, FrameSet.Effect4);
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��6����Ч��Դ")]
    public static void ResType_Effect5()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect5, FrameSet.Effect5);
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��7����Ч��Դ")]
    public static void ResType_Effect6()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect6, FrameSet.Effect6);
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��8����Ч��Դ")]
    public static void ResType_Effect7()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect7, FrameSet.Effect7);
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��9����Ч��Դ")]
    public static void ResType_Effect8()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect8, FrameSet.Effect8);
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��10����Ч��Դ")]
    public static void ResType_Effect9()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect9, FrameSet.Effect9);
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��11����Ч��Դ")]
    public static void ResType_Effect10()
    {
        monsterResIndex = 0;
        ResType_Effect(EnumResType.effect10, FrameSet.Effect10);
    }

    [MenuItem("Tools/��Ѫ���滳��/Effect/��12����Ч��Դ")]
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
            Debug.LogError("����������·��, Res Type = " + enumResType.ToString());
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

                EditorUtility.DisplayProgressBar(enumResType.ToString() + "��Դ����" + string.Format("{0} - {1}, {2}/{3}", pathIndex, paths.Count, resIndex, maxCount),
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
            Debug.LogError("����������·��, Res Type = " + enumResType.ToString());
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
            bool gender = false; //0�� 1Ů
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
                            EditorUtility.DisplayProgressBar(enumResType.ToString() + "��Դ����" + string.Format("{0} - {1}, {2}/{3}", pathIndex, paths.Count, resIndex, maxCount),
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
                //#region ���Դ���
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
            Debug.LogError("����������·��, Res Type = " + enumResType.ToString());
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
                        EditorUtility.DisplayProgressBar(enumResType.ToString() + "��Դ����" + string.Format("{0} - {1}, {2}/{3}", pathIndex, paths.Count, monsterResIndex, maxCount),
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
            Debug.LogError("����������·��, Res Type = " + enumResType.ToString());
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
                        EditorUtility.DisplayProgressBar(enumResType.ToString() + "��Դ����" + string.Format("{0} - {1}, {2}/{3}", pathIndex, paths.Count, monsterResIndex, maxCount),
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

            EditorUtility.DisplayProgressBar("������", path, index / (float)pointPaths.Count);
            index++;
        }

        EditorUtility.ClearProgressBar();
    }
}
