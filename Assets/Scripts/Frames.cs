using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region 模板
//Monster63.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
//Monster63.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
//Monster63.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
//Monster63.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
//Monster63.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

//Monster64.Frames.Add(MirAction.Standing, new Frame(224, 4, 0, 32));
//Monster64.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
//Monster64.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
//Monster64.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
//Monster64.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));

//Monster65.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
//Monster65.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
//Monster65.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
//Monster65.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
//Monster65.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));

//Monster66.Frames.Add(MirAction.Standing, new Frame(672, 4, 0, 32));
//Monster66.Frames.Add(MirAction.Walking, new Frame(704, 6, 0, 48));
//Monster66.Frames.Add(MirAction.Attack1, new Frame(752, 6, 0, 48));
//Monster66.Frames.Add(MirAction.BeiJi, new Frame(800, 2, 0, 16));
//Monster66.Frames.Add(MirAction.Die, new Frame(816, 10, 0, 80));
#endregion

public class FrameSet
{
    #region 帧对象
    public static FrameSet Players = new FrameSet();
    public static FrameSet Wings = new FrameSet();

    #region Monster
    public static FrameSet Monster1 = new FrameSet();
    public static FrameSet Monster2 = new FrameSet();
    public static FrameSet Monster3 = new FrameSet();
    public static FrameSet Monster4 = new FrameSet();
    public static FrameSet Monster5 = new FrameSet();
    public static FrameSet Monster6 = new FrameSet();
    public static FrameSet Monster7 = new FrameSet();
    public static FrameSet Monster8 = new FrameSet();
    public static FrameSet Monster9 = new FrameSet();
    public static FrameSet Monster10 = new FrameSet();
    public static FrameSet Monster11 = new FrameSet();
    public static FrameSet Monster12 = new FrameSet();
    public static FrameSet Monster13 = new FrameSet();
    public static FrameSet Monster14 = new FrameSet();
    public static FrameSet Monster15 = new FrameSet();
    public static FrameSet Monster16 = new FrameSet();
    public static FrameSet Monster17 = new FrameSet();
    public static FrameSet Monster18 = new FrameSet();
    public static FrameSet Monster19 = new FrameSet();
    public static FrameSet Monster20 = new FrameSet();
    public static FrameSet Monster21 = new FrameSet();
    public static FrameSet Monster22 = new FrameSet();
    public static FrameSet Monster23 = new FrameSet();
    public static FrameSet Monster24 = new FrameSet();
    public static FrameSet Monster25 = new FrameSet();
    public static FrameSet Monster26 = new FrameSet();
    public static FrameSet Monster27 = new FrameSet();
    public static FrameSet Monster28 = new FrameSet();
    public static FrameSet Monster29 = new FrameSet();
    public static FrameSet Monster30 = new FrameSet();
    public static FrameSet Monster31 = new FrameSet();
    public static FrameSet Monster32 = new FrameSet();
    public static FrameSet Monster33 = new FrameSet();
    public static FrameSet Monster34 = new FrameSet();
    public static FrameSet Monster35 = new FrameSet();
    public static FrameSet Monster36 = new FrameSet();
    public static FrameSet Monster37 = new FrameSet();
    public static FrameSet Monster38 = new FrameSet();
    public static FrameSet Monster39 = new FrameSet();
    public static FrameSet Monster40 = new FrameSet();
    public static FrameSet Monster41 = new FrameSet();
    public static FrameSet Monster42 = new FrameSet();
    public static FrameSet Monster43 = new FrameSet();
    public static FrameSet Monster44 = new FrameSet();
    public static FrameSet Monster45 = new FrameSet();
    public static FrameSet Monster46 = new FrameSet();
    public static FrameSet Monster47 = new FrameSet();
    public static FrameSet Monster48 = new FrameSet();
    public static FrameSet Monster49 = new FrameSet();
    public static FrameSet Monster50 = new FrameSet();
    public static FrameSet Monster51 = new FrameSet();
    public static FrameSet Monster52 = new FrameSet();
    public static FrameSet Monster53 = new FrameSet();
    public static FrameSet Monster54 = new FrameSet();
    public static FrameSet Monster55 = new FrameSet();
    public static FrameSet Monster56 = new FrameSet();
    public static FrameSet Monster57 = new FrameSet();
    public static FrameSet Monster58 = new FrameSet();
    public static FrameSet Monster59 = new FrameSet();
    public static FrameSet Monster60 = new FrameSet();
    public static FrameSet Monster61 = new FrameSet();
    public static FrameSet Monster62 = new FrameSet();
    public static FrameSet Monster63 = new FrameSet();
    public static FrameSet Monster64 = new FrameSet();
    public static FrameSet Monster65 = new FrameSet();
    public static FrameSet Monster66 = new FrameSet();
    public static FrameSet Monster67 = new FrameSet();
    public static FrameSet Monster68 = new FrameSet();
    public static FrameSet Monster69 = new FrameSet();
    public static FrameSet Monster70 = new FrameSet();
    public static FrameSet Monster71 = new FrameSet();
    public static FrameSet Monster72 = new FrameSet();
    public static FrameSet Monster73 = new FrameSet();
    public static FrameSet Monster74 = new FrameSet();
    public static FrameSet Monster75 = new FrameSet();
    public static FrameSet Monster76 = new FrameSet();
    public static FrameSet Monster77 = new FrameSet();
    public static FrameSet Monster78 = new FrameSet();
    public static FrameSet Monster79 = new FrameSet();
    public static FrameSet Monster80 = new FrameSet();
    public static FrameSet Monster81 = new FrameSet();
    public static FrameSet Monster82 = new FrameSet();
    public static FrameSet Monster83 = new FrameSet();
    public static FrameSet Monster84 = new FrameSet();
    public static FrameSet Monster85 = new FrameSet();
    public static FrameSet Monster86 = new FrameSet();
    public static FrameSet Monster87 = new FrameSet();
    public static FrameSet Monster88 = new FrameSet();
    public static FrameSet Monster89 = new FrameSet();
    public static FrameSet Monster90 = new FrameSet();
    public static FrameSet Monster91 = new FrameSet();
    public static FrameSet Monster92 = new FrameSet();
    public static FrameSet Monster93 = new FrameSet();
    public static FrameSet Monster94 = new FrameSet();
    public static FrameSet Monster95 = new FrameSet();
    public static FrameSet Monster96 = new FrameSet();
    public static FrameSet Monster97 = new FrameSet();
    public static FrameSet Monster98 = new FrameSet();
    public static FrameSet Monster99 = new FrameSet();
    public static FrameSet Monster100 = new FrameSet();
    public static FrameSet Monster101 = new FrameSet();
    public static FrameSet Monster102 = new FrameSet();
    public static FrameSet Monster103 = new FrameSet();
    public static FrameSet Monster104 = new FrameSet();
    public static FrameSet Monster105 = new FrameSet();
    public static FrameSet Monster106 = new FrameSet();
    public static FrameSet Monster107 = new FrameSet();
    public static FrameSet Monster108 = new FrameSet();
    public static FrameSet Monster109 = new FrameSet();
    public static FrameSet Monster110 = new FrameSet();
    public static FrameSet Monster111 = new FrameSet();
    public static FrameSet Monster112 = new FrameSet();
    public static FrameSet Monster113 = new FrameSet();
    public static FrameSet Monster114 = new FrameSet();
    public static FrameSet Monster115 = new FrameSet();
    public static FrameSet Monster116 = new FrameSet();
    public static FrameSet Monster117 = new FrameSet();
    public static FrameSet Monster118 = new FrameSet();
    public static FrameSet Monster119 = new FrameSet();
    public static FrameSet Monster120 = new FrameSet();
    public static FrameSet Monster121 = new FrameSet();
    public static FrameSet Monster122 = new FrameSet();
    public static FrameSet Monster123 = new FrameSet();
    public static FrameSet Monster124 = new FrameSet();
    public static FrameSet Monster125 = new FrameSet();
    public static FrameSet Monster126 = new FrameSet();
    public static FrameSet Monster127 = new FrameSet();
    public static FrameSet Monster128 = new FrameSet();
    public static FrameSet Monster129 = new FrameSet();
    public static FrameSet Monster130 = new FrameSet();
    public static FrameSet Monster131 = new FrameSet();
    public static FrameSet Monster132 = new FrameSet();
    public static FrameSet Monster133 = new FrameSet();
    public static FrameSet Monster134 = new FrameSet();
    public static FrameSet Monster135 = new FrameSet();
    public static FrameSet Monster136 = new FrameSet();
    public static FrameSet Monster137 = new FrameSet();
    public static FrameSet Monster138 = new FrameSet();
    public static FrameSet Monster139 = new FrameSet();
    public static FrameSet Monster140 = new FrameSet();
    public static FrameSet Monster141 = new FrameSet();
    public static FrameSet Monster142 = new FrameSet();
    public static FrameSet Monster143 = new FrameSet();
    public static FrameSet Monster144 = new FrameSet();
    public static FrameSet Monster145 = new FrameSet();
    public static FrameSet Monster146 = new FrameSet();
    public static FrameSet Monster147 = new FrameSet();
    public static FrameSet Monster148 = new FrameSet();
    public static FrameSet Monster149 = new FrameSet();
    public static FrameSet Monster150 = new FrameSet();
    public static FrameSet Monster151 = new FrameSet();
    public static FrameSet Monster152 = new FrameSet();
    public static FrameSet Monster153 = new FrameSet();
    public static FrameSet Monster154 = new FrameSet();
    public static FrameSet Monster155 = new FrameSet();
    public static FrameSet Monster156 = new FrameSet();
    public static FrameSet Monster157 = new FrameSet();
    public static FrameSet Monster158 = new FrameSet();
    public static FrameSet Monster159 = new FrameSet();
    public static FrameSet Monster160 = new FrameSet();
    public static FrameSet Monster161 = new FrameSet();
    public static FrameSet Monster162 = new FrameSet();
    public static FrameSet Monster163 = new FrameSet();
    public static FrameSet Monster164 = new FrameSet();
    public static FrameSet Monster165 = new FrameSet();
    public static FrameSet Monster166 = new FrameSet();
    public static FrameSet Monster167 = new FrameSet();
    public static FrameSet Monster168 = new FrameSet();
    public static FrameSet Monster169 = new FrameSet();
    public static FrameSet Monster170 = new FrameSet();
    public static FrameSet Monster171 = new FrameSet();
    public static FrameSet Monster172 = new FrameSet();
    public static FrameSet Monster173 = new FrameSet();
    public static FrameSet Monster174 = new FrameSet();
    public static FrameSet Monster175 = new FrameSet();
    public static FrameSet Monster176 = new FrameSet();
    public static FrameSet Monster177 = new FrameSet();
    public static FrameSet Monster178 = new FrameSet();
    public static FrameSet Monster179 = new FrameSet();
    public static FrameSet Monster180 = new FrameSet();
    public static FrameSet Monster181 = new FrameSet();
    public static FrameSet Monster182 = new FrameSet();
    public static FrameSet Monster183 = new FrameSet();
    public static FrameSet Monster184 = new FrameSet();
    public static FrameSet Monster185 = new FrameSet();
    public static FrameSet Monster186 = new FrameSet();
    public static FrameSet Monster187 = new FrameSet();
    public static FrameSet Monster188 = new FrameSet();
    public static FrameSet Monster189 = new FrameSet();
    public static FrameSet Monster190 = new FrameSet();
    public static FrameSet Monster191 = new FrameSet();
    public static FrameSet Monster192 = new FrameSet();
    public static FrameSet Monster193 = new FrameSet();
    public static FrameSet Monster194 = new FrameSet();
    public static FrameSet Monster195 = new FrameSet();
    public static FrameSet Monster196 = new FrameSet();
    public static FrameSet Monster197 = new FrameSet();
    public static FrameSet Monster198 = new FrameSet();
    public static FrameSet Monster199 = new FrameSet();
    public static FrameSet Monster200 = new FrameSet();
    public static FrameSet Monster201 = new FrameSet();
    public static FrameSet Monster202 = new FrameSet();
    public static FrameSet Monster203 = new FrameSet();
    public static FrameSet Monster204 = new FrameSet();
    public static FrameSet Monster205 = new FrameSet();
    public static FrameSet Monster206 = new FrameSet();
    public static FrameSet Monster207 = new FrameSet();
    public static FrameSet Monster208 = new FrameSet();
    public static FrameSet Monster209 = new FrameSet();
    public static FrameSet Monster210 = new FrameSet();
    public static FrameSet Monster211 = new FrameSet();
    public static FrameSet Monster212 = new FrameSet();
    public static FrameSet Monster213 = new FrameSet();
    public static FrameSet Monster214 = new FrameSet();
    public static FrameSet Monster215 = new FrameSet();
    public static FrameSet Monster216 = new FrameSet();
    public static FrameSet Monster217 = new FrameSet();
    public static FrameSet Monster218 = new FrameSet();
    public static FrameSet Monster219 = new FrameSet();
    public static FrameSet Monster220 = new FrameSet();
    public static FrameSet Monster221 = new FrameSet();
    public static FrameSet Monster222 = new FrameSet();
    public static FrameSet Monster223 = new FrameSet();
    public static FrameSet Monster224 = new FrameSet();
    public static FrameSet Monster225 = new FrameSet();
    public static FrameSet Monster226 = new FrameSet();
    public static FrameSet Monster227 = new FrameSet();
    public static FrameSet Monster228 = new FrameSet();
    public static FrameSet Monster229 = new FrameSet();
    public static FrameSet Monster230 = new FrameSet();
    public static FrameSet Monster231 = new FrameSet();
    public static FrameSet Monster232 = new FrameSet();
    public static FrameSet Monster233 = new FrameSet();
    public static FrameSet Monster234 = new FrameSet();
    public static FrameSet Monster235 = new FrameSet();
    public static FrameSet Monster236 = new FrameSet();
    public static FrameSet Monster237 = new FrameSet();
    public static FrameSet Monster238 = new FrameSet();
    public static FrameSet Monster239 = new FrameSet();
    public static FrameSet Monster240 = new FrameSet();
    public static FrameSet Monster241 = new FrameSet();
    public static FrameSet Monster242 = new FrameSet();
    public static FrameSet Monster243 = new FrameSet();
    public static FrameSet Monster244 = new FrameSet();
    public static FrameSet Monster245 = new FrameSet();
    public static FrameSet Monster246 = new FrameSet();
    public static FrameSet Monster247 = new FrameSet();
    public static FrameSet Monster248 = new FrameSet();
    public static FrameSet Monster249 = new FrameSet();
    public static FrameSet Monster250 = new FrameSet();
    public static FrameSet Monster251 = new FrameSet();
    public static FrameSet Monster252 = new FrameSet();
    public static FrameSet Monster253 = new FrameSet();
    public static FrameSet Monster254 = new FrameSet();
    public static FrameSet Monster255 = new FrameSet();
    public static FrameSet Monster256 = new FrameSet();
    public static FrameSet Monster257 = new FrameSet();
    public static FrameSet Monster258 = new FrameSet();
    public static FrameSet Monster259 = new FrameSet();
    public static FrameSet Monster260 = new FrameSet();
    public static FrameSet Monster261 = new FrameSet();
    public static FrameSet Monster262 = new FrameSet();
    public static FrameSet Monster263 = new FrameSet();
    public static FrameSet Monster264 = new FrameSet();
    public static FrameSet Monster265 = new FrameSet();
    public static FrameSet Monster266 = new FrameSet();
    public static FrameSet Monster267 = new FrameSet();
    public static FrameSet Monster268 = new FrameSet();
    public static FrameSet Monster269 = new FrameSet();
    public static FrameSet Monster270 = new FrameSet();
    public static FrameSet Monster271 = new FrameSet();
    public static FrameSet Monster272 = new FrameSet();
    public static FrameSet Monster273 = new FrameSet();
    public static FrameSet Monster274 = new FrameSet();
    public static FrameSet Monster275 = new FrameSet();
    public static FrameSet Monster276 = new FrameSet();
    public static FrameSet Monster277 = new FrameSet();
    public static FrameSet Monster278 = new FrameSet();
    public static FrameSet Monster279 = new FrameSet();
    public static FrameSet Monster280 = new FrameSet();
    #endregion

    #region Effect
    public static FrameSet Effect = new FrameSet();
    public static FrameSet Effect1 = new FrameSet();
    public static FrameSet Effect2 = new FrameSet();
    public static FrameSet Effect3 = new FrameSet();
    public static FrameSet Effect4 = new FrameSet();
    public static FrameSet Effect5 = new FrameSet();
    public static FrameSet Effect6 = new FrameSet();
    public static FrameSet Effect7 = new FrameSet();
    public static FrameSet Effect8 = new FrameSet();
    public static FrameSet Effect9 = new FrameSet(); 
    public static FrameSet Effect10 = new FrameSet();
    public static FrameSet Effect11 = new FrameSet();
    #endregion
    #endregion

    public int startFrameIndex = -1;
    public int resMaxFrame;
    public Dictionary<MirAction, Frame> Frames = new Dictionary<MirAction, Frame>();
    public List<Frame> EffectFrames = new List<Frame>();

    static FrameSet()
    {
        #region Player Frames
        Players.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Players.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Players.Frames.Add(MirAction.Running, new Frame(80, 6, 0, 48));
        Players.Frames.Add(MirAction.BeiZhan, new Frame(128, 1, 0, 8));
        Players.Frames.Add(MirAction.Attack1, new Frame(136, 6, 0, 48));
        Players.Frames.Add(MirAction.Attack2, new Frame(184, 6, 0, 48));
        Players.Frames.Add(MirAction.Attack3, new Frame(232, 8, 0, 64));
        Players.Frames.Add(MirAction.ShiFa, new Frame(296, 6, 0, 48));
        Players.Frames.Add(MirAction.ShiQu, new Frame(344, 2, 0, 16));
        Players.Frames.Add(MirAction.BeiJi, new Frame(360, 3, 0, 24));
        Players.Frames.Add(MirAction.Die, new Frame(384, 4, 0, 32));
        Players.resMaxFrame = Players.Frames[MirAction.Die].FrameIndex;
        #endregion

        #region Wings Frames
        Wings.Frames.Add(MirAction.Standing, new Frame(0, 8, 0, 64));
        Wings.Frames.Add(MirAction.Walking, new Frame(64, 6, 0, 48));
        Wings.Frames.Add(MirAction.Running, new Frame(112, 6, 0, 48));
        Wings.Frames.Add(MirAction.BeiZhan, new Frame(160, 1, 0, 8));
        Wings.Frames.Add(MirAction.Attack1, new Frame(168, 6, 0, 48));
        Wings.Frames.Add(MirAction.Attack2, new Frame(216, 6, 0, 48));
        Wings.Frames.Add(MirAction.Attack3, new Frame(264, 8, 0, 64));
        Wings.Frames.Add(MirAction.ShiFa, new Frame(328, 6, 0, 48));
        Wings.Frames.Add(MirAction.ShiQu, new Frame(376, 2, 0, 16));
        Wings.Frames.Add(MirAction.BeiJi, new Frame(392, 3, 0, 24));
        Wings.Frames.Add(MirAction.Die, new Frame(416, 4, 0, 32));
        Wings.resMaxFrame = Wings.Frames[MirAction.Die].FrameIndex;
        #endregion

        #region Monster Frames
        #region E:\RXCQ\bmp\monster\Mon1
        Monster1.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster1.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster1.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));

        Monster2.Frames.Add(MirAction.Standing, new Frame(128, 4, 0, 32));
        Monster2.Frames.Add(MirAction.Walking, new Frame(160, 6, 0, 48));
        Monster2.Frames.Add(MirAction.Attack1, new Frame(208, 6, 0, 48));
        Monster2.Frames.Add(MirAction.BeiJi, new Frame(256, 2, 0, 16));
        Monster2.Frames.Add(MirAction.Die, new Frame(272, 4, 0, 32));

        Monster3.Frames.Add(MirAction.Standing, new Frame(304, 4, 0, 32));
        Monster3.Frames.Add(MirAction.Attack1, new Frame(336, 6, 0, 48));
        Monster3.Frames.Add(MirAction.Skill, new Frame(384, 3, 0, 24));
        #endregion

        #region E:\RXCQ\bmp\monster\Mon2
        Monster4.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 4));
        Monster4.Frames.Add(MirAction.Standing1, new Frame(4, 16, 0, 16));
        Monster4.Frames.Add(MirAction.Attack1, new Frame(20, 6, 0, 48));
        Monster4.Frames.Add(MirAction.BeiJi, new Frame(68, 2, 0, 16));
        Monster4.Frames.Add(MirAction.Die, new Frame(84, 10, 0, 80));

        Monster5.Frames.Add(MirAction.Standing, new Frame(308, 4, 0, 32, true));
        Monster5.Frames.Add(MirAction.Walking, new Frame(340, 6, 0, 48, true));
        Monster5.Frames.Add(MirAction.Attack1, new Frame(388, 6, 0, 48, true));
        Monster5.Frames.Add(MirAction.Attack2, new Frame(436, 6, 0, 48, true));
        Monster5.Frames.Add(MirAction.Attack3, new Frame(484, 6, 0, 48, true));
        Monster5.Frames.Add(MirAction.BeiJi, new Frame(532, 2, 0, 16, true));
        Monster5.Frames.Add(MirAction.Die, new Frame(548, 20, 0, 160, true));

        Monster6.Frames.Add(MirAction.Standing, new Frame(708, 4, 0, 32, true));
        Monster6.Frames.Add(MirAction.Walking, new Frame(740, 6, 0, 48, true));
        Monster6.Frames.Add(MirAction.Attack1, new Frame(788, 6, 0, 48, true));
        Monster6.Frames.Add(MirAction.Attack2, new Frame(836, 6, 0, 48, true));
        Monster6.Frames.Add(MirAction.Attack3, new Frame(884, 6, 0, 48, true));
        Monster6.Frames.Add(MirAction.BeiJi, new Frame(932, 2, 0, 16, true));
        Monster6.Frames.Add(MirAction.Die, new Frame(948, 20, 0, 160, true));

        Monster7.Frames.Add(MirAction.Standing, new Frame(1108, 4, 0, 32, true));
        Monster7.Frames.Add(MirAction.Walking, new Frame(1140, 6, 0, 48, true));
        Monster7.Frames.Add(MirAction.Attack1, new Frame(1188, 6, 0, 48, true));
        Monster7.Frames.Add(MirAction.BeiJi, new Frame(1236, 2, 0, 16, true));
        Monster7.Frames.Add(MirAction.Die, new Frame(1252, 4, 0, 32, true));
        Monster7.Frames.Add(MirAction.ShiFa, new Frame(1284, 6, 0, 48, true));

        Monster8.Frames.Add(MirAction.Standing, new Frame(1332, 4, 0, 32, true));
        Monster8.Frames.Add(MirAction.Walking, new Frame(1364, 6, 0, 48, true));
        Monster8.Frames.Add(MirAction.Attack1, new Frame(1412, 6, 0, 48, true));
        Monster8.Frames.Add(MirAction.BeiJi, new Frame(1460, 2, 0, 16, true));
        Monster8.Frames.Add(MirAction.Die, new Frame(1476, 4, 0, 32, true));
        Monster8.Frames.Add(MirAction.ShiFa, new Frame(1508, 6, 0, 48, true));

        Monster9.Frames.Add(MirAction.Standing, new Frame(1556, 4, 0, 32, true));
        Monster9.Frames.Add(MirAction.Walking, new Frame(1588, 6, 0, 48, true));
        Monster9.Frames.Add(MirAction.Attack1, new Frame(1636, 6, 0, 48, true));
        Monster9.Frames.Add(MirAction.BeiJi, new Frame(1684, 2, 0, 16, true));
        Monster9.Frames.Add(MirAction.Die, new Frame(1700, 4, 0, 32, true));
        Monster9.Frames.Add(MirAction.ShiFa, new Frame(1732, 6, 0, 48, true));

        Monster10.Frames.Add(MirAction.Standing, new Frame(1780, 4, 0, 32, true));
        Monster10.Frames.Add(MirAction.Walking, new Frame(1588 + 224, 6, 0, 48, true));
        Monster10.Frames.Add(MirAction.Attack1, new Frame(1636 + 224, 6, 0, 48, true));
        Monster10.Frames.Add(MirAction.BeiJi, new Frame(1684 + 224, 2, 0, 16, true));
        Monster10.Frames.Add(MirAction.Die, new Frame(1700 + 224, 4, 0, 32, true));
        Monster10.Frames.Add(MirAction.ShiFa, new Frame(1732 + 224, 6, 0, 48, true));

        Monster11.Frames.Add(MirAction.Standing, new Frame(1780 + 224, 4, 0, 32, true));
        Monster11.Frames.Add(MirAction.Walking, new Frame(1588 + (224  * 2), 6, 0, 48, true));
        Monster11.Frames.Add(MirAction.Attack1, new Frame(1636 + (224 * 2), 6, 0, 48, true));
        Monster11.Frames.Add(MirAction.BeiJi, new Frame(1684 + (224 * 2), 2, 0, 16, true));
        Monster11.Frames.Add(MirAction.Die, new Frame(1700 + (224 * 2), 4, 0, 32, true));
        Monster11.Frames.Add(MirAction.ShiFa, new Frame(1732 + (224 * 2), 6, 0, 48, true));

        Monster12.Frames.Add(MirAction.Standing, new Frame(2004, 4, 0, 32, true));
        Monster12.Frames.Add(MirAction.Walking, new Frame(2036, 6, 0, 48, true));
        Monster12.Frames.Add(MirAction.Attack1, new Frame(2084, 6, 0, 47, true));
        Monster12.Frames.Add(MirAction.BeiJi, new Frame(2131, 2, 0, 16, true));
        Monster12.Frames.Add(MirAction.Die, new Frame(2147, 10, 0, 80, true));

        Monster13.Frames.Add(MirAction.Standing, new Frame(2227, 4, 0, 32, true));
        Monster13.Frames.Add(MirAction.Walking, new Frame(2259, 6, 0, 48, true));
        Monster13.Frames.Add(MirAction.Attack1, new Frame(2307, 6, 0, 47, true));
        Monster13.Frames.Add(MirAction.BeiJi, new Frame(2354, 2, 0, 16, true));
        Monster13.Frames.Add(MirAction.Die, new Frame(2370, 10, 0, 80, true));

        Monster14.Frames.Add(MirAction.Standing1, new Frame(2450, 19, 0, 19, true));
        Monster14.Frames.Add(MirAction.Standing, new Frame(2469, 4, 0, 32, true));
        Monster14.Frames.Add(MirAction.Walking, new Frame(2501, 6, 0, 48, true));
        Monster14.Frames.Add(MirAction.Attack1, new Frame(2549, 6, 0, 48, true));
        Monster14.Frames.Add(MirAction.BeiJi, new Frame(2597, 2, 0, 16, true));
        Monster14.Frames.Add(MirAction.Die, new Frame(2613, 10, 0, 80, true));

        Monster15.Frames.Add(MirAction.Standing1, new Frame(2693, 19, 0, 19, true));
        Monster15.Frames.Add(MirAction.Standing, new Frame(2712, 4, 0, 32, true));
        Monster15.Frames.Add(MirAction.Walking, new Frame(2744, 6, 0, 48, true));
        Monster15.Frames.Add(MirAction.Attack1, new Frame(2792, 6, 0, 48, true));
        Monster15.Frames.Add(MirAction.BeiJi, new Frame(2840, 2, 0, 16, true));
        Monster15.Frames.Add(MirAction.Die, new Frame(2856, 10, 0, 80, true));
        #endregion

        #region E:\RXCQ\bmp\monster\Mon3
        Monster16.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster16.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster16.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster16.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster16.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster17.Frames.Add(MirAction.Standing, new Frame(244, 4, 0, 32));
        Monster17.Frames.Add(MirAction.Walking, new Frame(276, 6, 3, 48));
        Monster17.Frames.Add(MirAction.Attack1, new Frame(348, 6, 3, 48));
        Monster17.Frames.Add(MirAction.Weapon1, new Frame(282, 3, 6, 24));
        Monster17.Frames.Add(MirAction.Weapon2, new Frame(354, 3, 6, 24));
        Monster17.Frames.Add(MirAction.BeiJi, new Frame(420, 2, 0, 16));
        Monster17.Frames.Add(MirAction.Die, new Frame(436, 10, 0, 80));

        Monster18.Frames.Add(MirAction.Standing, new Frame(516, 4, 0, 32));
        Monster18.Frames.Add(MirAction.Walking, new Frame(548, 6, 0, 48));
        Monster18.Frames.Add(MirAction.Attack1, new Frame(596, 6, 0, 48));
        Monster18.Frames.Add(MirAction.BeiJi, new Frame(644, 2, 0, 16));
        Monster18.Frames.Add(MirAction.Die, new Frame(660, 10, 0, 80));

        Monster19.Frames.Add(MirAction.Standing, new Frame(740, 4, 0, 32));
        Monster19.Frames.Add(MirAction.Walking, new Frame(772, 6, 0, 48));
        Monster19.Frames.Add(MirAction.Attack1, new Frame(820, 6, 0, 48));
        Monster19.Frames.Add(MirAction.BeiJi, new Frame(868, 2, 0, 16));
        Monster19.Frames.Add(MirAction.Die, new Frame(884, 10, 0, 80));

        Monster20.Frames.Add(MirAction.Standing, new Frame(964, 4, 5, 32));
        Monster20.Frames.Add(MirAction.Weapon1, new Frame(968, 5, 4, 40));
        Monster20.Frames.Add(MirAction.Walking, new Frame(1036, 6, 0, 48));
        Monster20.Frames.Add(MirAction.Attack1, new Frame(1084, 6, 0, 48));
        Monster20.Frames.Add(MirAction.BeiJi, new Frame(1132, 2, 0, 16));
        Monster20.Frames.Add(MirAction.Die, new Frame(1148, 4, 0, 32));

        Monster21.Frames.Add(MirAction.Standing, new Frame(1180, 4, 0, 32));
        Monster21.Frames.Add(MirAction.Walking, new Frame(1212, 6, 0, 48));
        Monster21.Frames.Add(MirAction.Attack1, new Frame(1260, 6, 0, 48));
        Monster21.Frames.Add(MirAction.BeiJi, new Frame(1308, 2, 0, 16));
        Monster21.Frames.Add(MirAction.Die, new Frame(1324, 10, 0, 80));

        Monster22.Frames.Add(MirAction.Standing, new Frame(1404, 4, 0, 32));
        Monster22.Frames.Add(MirAction.Walking, new Frame(1436, 6, 0, 48));
        Monster22.Frames.Add(MirAction.Attack1, new Frame(1484, 6, 0, 48));
        Monster22.Frames.Add(MirAction.BeiJi, new Frame(1532, 2, 0, 16));
        Monster22.Frames.Add(MirAction.Die, new Frame(1548, 10, 0, 80));

        Monster23.Frames.Add(MirAction.Standing, new Frame(1628, 4, 0, 32));
        Monster23.Frames.Add(MirAction.Walking, new Frame(1660, 6, 0, 48));
        Monster23.Frames.Add(MirAction.Attack1, new Frame(1708, 6, 0, 48));
        Monster23.Frames.Add(MirAction.BeiJi, new Frame(1756, 2, 0, 16));
        Monster23.Frames.Add(MirAction.Die, new Frame(1772, 10, 0, 80));

        Monster24.Frames.Add(MirAction.Standing, new Frame(1628, 4, 0, 32));
        Monster24.Frames.Add(MirAction.Walking, new Frame(1660, 6, 0, 48));
        Monster24.Frames.Add(MirAction.Attack1, new Frame(1708, 6, 0, 48));
        Monster24.Frames.Add(MirAction.BeiJi, new Frame(1756, 2, 0, 16));
        Monster24.Frames.Add(MirAction.Die, new Frame(1772, 10, 0, 80));

        Monster25.Frames.Add(MirAction.Standing, new Frame(1862, 4, 0, 32));
        Monster25.Frames.Add(MirAction.Walking, new Frame(1894, 6, 3, 48));
        Monster25.Frames.Add(MirAction.Weapon1, new Frame(1900, 3, 6, 24));
        Monster25.Frames.Add(MirAction.Weapon2, new Frame(1972, 3, 6, 24));
        Monster25.Frames.Add(MirAction.Attack1, new Frame(1966, 6, 3, 48));
        Monster25.Frames.Add(MirAction.BeiJi, new Frame(2038, 2, 0, 16));
        Monster25.Frames.Add(MirAction.Die, new Frame(2054, 10, 0, 80));

        Monster26.Frames.Add(MirAction.Standing, new Frame(2134, 4, 0, 32));
        Monster26.Frames.Add(MirAction.Walking, new Frame(2166, 6, 0, 48));
        Monster26.Frames.Add(MirAction.Attack1, new Frame(2214, 6, 0, 48));
        Monster26.Frames.Add(MirAction.BeiJi, new Frame(2262, 2, 0, 16));
        Monster26.Frames.Add(MirAction.Die, new Frame(2278, 10, 0, 80));
        Monster26.Frames.Add(MirAction.Weapon1, new Frame(2358, 8, 0, 64, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\Mon4
        Monster27.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster27.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster27.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster27.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster27.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster28.Frames.Add(MirAction.Standing, new Frame(224, 4, 0, 32));
        Monster28.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
        Monster28.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
        Monster28.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
        Monster28.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));
        Monster28.Frames.Add(MirAction.Weapon1, new Frame(1120, 7, 0, 56));

        Monster29.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster29.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
        Monster29.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
        Monster29.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
        Monster29.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));
        Monster29.Frames.Add(MirAction.Weapon1, new Frame(1120, 7, 0, 56));

        Monster30.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster30.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster30.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster30.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster30.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));

        Monster31.Frames.Add(MirAction.Standing, new Frame(672, 4, 0, 32));
        Monster31.Frames.Add(MirAction.Walking, new Frame(704, 6, 0, 48));
        Monster31.Frames.Add(MirAction.Attack1, new Frame(752, 6, 0, 48));
        Monster31.Frames.Add(MirAction.BeiJi, new Frame(800, 2, 0, 16));
        Monster31.Frames.Add(MirAction.Die, new Frame(816, 10, 0, 80));

        Monster32.Frames.Add(MirAction.Standing, new Frame(896, 4, 0, 32));
        Monster32.Frames.Add(MirAction.Walking, new Frame(928, 6, 0, 48));
        Monster32.Frames.Add(MirAction.Attack1, new Frame(976, 6, 0, 48));
        Monster32.Frames.Add(MirAction.BeiJi, new Frame(1024, 2, 0, 16));
        Monster32.Frames.Add(MirAction.Die, new Frame(1040, 10, 0, 80));
        Monster32.Frames.Add(MirAction.Weapon1, new Frame(1176, 6, 0, 48));

        Monster33.Frames.Add(MirAction.Standing, new Frame(1224, 4, 0, 32));
        Monster33.Frames.Add(MirAction.Walking, new Frame(1256, 6, 0, 48));
        Monster33.Frames.Add(MirAction.Attack1, new Frame(1304, 6, 0, 48));
        Monster33.Frames.Add(MirAction.BeiJi, new Frame(1352, 2, 0, 16));
        Monster33.Frames.Add(MirAction.Die, new Frame(1368, 10, 0, 80));

        Monster34.Frames.Add(MirAction.Standing, new Frame(1448, 4, 0, 32));
        Monster34.Frames.Add(MirAction.Walking, new Frame(1480, 6, 0, 48));
        Monster34.Frames.Add(MirAction.Attack1, new Frame(1528, 6, 0, 48));
        Monster34.Frames.Add(MirAction.BeiJi, new Frame(1576, 2, 0, 16));
        Monster34.Frames.Add(MirAction.Die, new Frame(1592, 10, 0, 80));
        Monster34.Frames.Add(MirAction.Standing1, new Frame(1672, 10, 0, 10));

        Monster35.Frames.Add(MirAction.Standing, new Frame(1682, 4, 0, 32));
        Monster35.Frames.Add(MirAction.Walking, new Frame(1714, 6, 0, 48));
        Monster35.Frames.Add(MirAction.Attack1, new Frame(1762, 6, 0, 48));
        Monster35.Frames.Add(MirAction.BeiJi, new Frame(1810, 2, 0, 16));
        Monster35.Frames.Add(MirAction.Die, new Frame(1826, 10, 0, 80));

        Monster36.Frames.Add(MirAction.Standing, new Frame(1906, 4, 0, 32));
        Monster36.Frames.Add(MirAction.Walking, new Frame(1938, 6, 0, 48));
        Monster36.Frames.Add(MirAction.Attack1, new Frame(1986, 6, 0, 48));
        Monster36.Frames.Add(MirAction.BeiJi, new Frame(2034, 2, 0, 16));
        Monster36.Frames.Add(MirAction.Die, new Frame(2050, 10, 0, 80));
        Monster36.Frames.Add(MirAction.Weapon1, new Frame(2130, 6, 0, 48, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\Mon5
        Monster37.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster37.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster37.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster37.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster37.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster37.Frames.Add(MirAction.Weapon1, new Frame(232, 6, 0, 48));
        Monster37.Frames.Add(MirAction.Weapon2, new Frame(280, 6, 0, 48));

        Monster38.Frames.Add(MirAction.Standing, new Frame(340, 5, 0, 5));
        Monster38.Frames.Add(MirAction.Attack1, new Frame(345, 10, 0, 10));
        Monster38.Frames.Add(MirAction.Die, new Frame(355, 7, 0, 7));

        Monster39.Frames.Add(MirAction.Standing, new Frame(362, 4, 0, 32));
        Monster39.Frames.Add(MirAction.Walking, new Frame(394, 6, 0, 48));
        Monster39.Frames.Add(MirAction.Attack1, new Frame(442, 6, 0, 48));
        Monster39.Frames.Add(MirAction.BeiJi, new Frame(490, 2, 0, 16));
        Monster39.Frames.Add(MirAction.Die, new Frame(506, 10, 0, 80));

        Monster40.Frames.Add(MirAction.Standing, new Frame(586, 4, 0, 32));
        Monster40.Frames.Add(MirAction.Walking, new Frame(618, 6, 0, 48));
        Monster40.Frames.Add(MirAction.Attack1, new Frame(666, 6, 0, 48));
        Monster40.Frames.Add(MirAction.BeiJi, new Frame(714, 2, 0, 16));
        Monster40.Frames.Add(MirAction.Die, new Frame(730, 10, 0, 80));

        Monster41.Frames.Add(MirAction.Standing, new Frame(811, 4, 0, 32));
        Monster41.Frames.Add(MirAction.Walking, new Frame(843, 6, 0, 48));
        Monster41.Frames.Add(MirAction.Attack1, new Frame(891, 6, 0, 48));
        Monster41.Frames.Add(MirAction.BeiJi, new Frame(939, 2, 0, 16));
        Monster41.Frames.Add(MirAction.Die, new Frame(955, 10, 0, 80));

        Monster42.Frames.Add(MirAction.Standing, new Frame(1035, 4, 0, 32));
        Monster42.Frames.Add(MirAction.Walking, new Frame(1067, 6, 0, 48));
        Monster42.Frames.Add(MirAction.Attack1, new Frame(1115, 6, 0, 48));
        Monster42.Frames.Add(MirAction.BeiJi, new Frame(1163, 2, 0, 16));
        Monster42.Frames.Add(MirAction.Die, new Frame(1179, 10, 0, 80));

        Monster43.Frames.Add(MirAction.Standing, new Frame(1259, 4, 0, 32));
        Monster43.Frames.Add(MirAction.Walking, new Frame(1291, 6, 0, 48));
        Monster43.Frames.Add(MirAction.Attack1, new Frame(1339, 6, 0, 48));
        Monster43.Frames.Add(MirAction.BeiJi, new Frame(1387, 2, 0, 16));
        Monster43.Frames.Add(MirAction.Die, new Frame(1403, 10, 0, 80));

        Monster44.Frames.Add(MirAction.Standing, new Frame(1483, 4, 0, 32));
        Monster44.Frames.Add(MirAction.Walking, new Frame(1515, 6, 1, 48));
        Monster44.Frames.Add(MirAction.Weapon1, new Frame(1521, 1, 6, 8));
        Monster44.Frames.Add(MirAction.Weapon2, new Frame(1577, 1, 6, 8));
        Monster44.Frames.Add(MirAction.Attack1, new Frame(1571, 6, 1, 48));
        Monster44.Frames.Add(MirAction.BeiJi, new Frame(1627, 2, 0, 16));
        Monster44.Frames.Add(MirAction.Die, new Frame(1643, 10, 0, 80));

        Monster45.Frames.Add(MirAction.Standing, new Frame(1723, 4, 0, 32));
        Monster45.Frames.Add(MirAction.Walking, new Frame(1755, 6, 0, 48));
        Monster45.Frames.Add(MirAction.Attack1, new Frame(1803, 6, 0, 48));
        Monster45.Frames.Add(MirAction.BeiJi, new Frame(1851, 2, 0, 16));
        Monster45.Frames.Add(MirAction.Die, new Frame(1867, 10, 0, 80));

        Monster46.Frames.Add(MirAction.Standing, new Frame(1947, 4, 0, 32));
        Monster46.Frames.Add(MirAction.Walking, new Frame(1979, 6, 0, 48));
        Monster46.Frames.Add(MirAction.Attack1, new Frame(2027, 6, 0, 48));
        Monster46.Frames.Add(MirAction.BeiJi, new Frame(2075, 2, 0, 16));
        Monster46.Frames.Add(MirAction.Die, new Frame(2091, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\Mon6
        Monster47.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster47.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster47.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster47.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster47.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster47.Frames.Add(MirAction.Standing1, new Frame(224, 10, 0, 80));
        Monster47.Frames.Add(MirAction.Standing2, new Frame(304, 8, 0, 8));

        Monster48.Frames.Add(MirAction.Standing, new Frame(312, 4, 0, 32));
        Monster48.Frames.Add(MirAction.Standing1, new Frame(536, 10, 0, 80));
        Monster48.Frames.Add(MirAction.Walking, new Frame(344, 6, 0, 48));
        Monster48.Frames.Add(MirAction.Attack1, new Frame(392, 6, 0, 48));
        Monster48.Frames.Add(MirAction.BeiJi, new Frame(440, 2, 0, 16));
        Monster48.Frames.Add(MirAction.Die, new Frame(456, 10, 0, 80));

        Monster49.Frames.Add(MirAction.Standing, new Frame(616, 4, 0, 32));
        Monster49.Frames.Add(MirAction.Walking, new Frame(648, 6, 0, 48));
        Monster49.Frames.Add(MirAction.Attack1, new Frame(696, 6, 0, 48));
        Monster49.Frames.Add(MirAction.BeiJi, new Frame(744, 2, 0, 16));
        Monster49.Frames.Add(MirAction.Die, new Frame(760, 10, 0, 80));
        Monster49.Frames.Add(MirAction.Standing1, new Frame(840, 10, 0, 80));

        Monster50.Frames.Add(MirAction.Standing, new Frame(920, 4, 0, 32));
        Monster50.Frames.Add(MirAction.Walking, new Frame(952, 6, 0, 48));
        Monster50.Frames.Add(MirAction.Attack1, new Frame(1000, 6, 0, 48));
        Monster50.Frames.Add(MirAction.BeiJi, new Frame(1048, 2, 0, 16));
        Monster50.Frames.Add(MirAction.Die, new Frame(1064, 10, 0, 80));
        Monster50.Frames.Add(MirAction.Standing1, new Frame(1144, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon7
        Monster51.Frames.Add(MirAction.Standing, new Frame(0, 6, 0, 48));
        Monster51.Frames.Add(MirAction.Standing1, new Frame(48, 4, 0, 32));
        Monster51.Frames.Add(MirAction.Walking, new Frame(80, 6, 0, 48));
        Monster51.Frames.Add(MirAction.Attack1, new Frame(128, 6, 0, 48));
        Monster51.Frames.Add(MirAction.BeiJi, new Frame(176, 2, 0, 16));
        Monster51.Frames.Add(MirAction.Die, new Frame(192, 10, 0, 80));

        Monster52.Frames.Add(MirAction.Standing, new Frame(272, 6, 0, 48));
        Monster52.Frames.Add(MirAction.Standing1, new Frame(320, 4, 0, 32));
        Monster52.Frames.Add(MirAction.Walking, new Frame(352, 6, 0, 48));
        Monster52.Frames.Add(MirAction.Attack1, new Frame(400, 6, 0, 48));
        Monster52.Frames.Add(MirAction.BeiJi, new Frame(448, 2, 0, 16));
        Monster52.Frames.Add(MirAction.Die, new Frame(464, 10, 0, 80));

        Monster53.Frames.Add(MirAction.Standing, new Frame(544, 20, 0, 20));
        Monster53.Frames.Add(MirAction.Standing1, new Frame(564, 4, 0, 32));
        Monster53.Frames.Add(MirAction.Walking, new Frame(596, 6, 0, 48));
        Monster53.Frames.Add(MirAction.Attack1, new Frame(644, 6, 0, 48));
        Monster53.Frames.Add(MirAction.BeiJi, new Frame(692, 2, 0, 16));
        Monster53.Frames.Add(MirAction.Die, new Frame(708, 10, 0, 80));
        Monster53.Frames.Add(MirAction.Weapon1, new Frame(788, 8, 0, 64, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\Mon8
        Monster54.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster54.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster54.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster54.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster54.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster55.Frames.Add(MirAction.Standing, new Frame(225, 4, 0, 32));
        Monster55.Frames.Add(MirAction.Walking, new Frame(257, 6, 3, 48));
        Monster55.Frames.Add(MirAction.Weapon1, new Frame(263, 3, 6, 24));
        Monster55.Frames.Add(MirAction.Weapon2, new Frame(335, 3, 6, 24));
        Monster55.Frames.Add(MirAction.Attack1, new Frame(329, 6, 3, 48));
        Monster55.Frames.Add(MirAction.BeiJi, new Frame(401, 2, 0, 16));
        Monster55.Frames.Add(MirAction.Die, new Frame(417, 10, 0, 80));

        Monster56.Frames.Add(MirAction.Standing, new Frame(497, 4, 0, 32));
        Monster56.Frames.Add(MirAction.Walking, new Frame(529, 6, 0, 48));
        Monster56.Frames.Add(MirAction.Attack1, new Frame(577, 6, 0, 48));
        Monster56.Frames.Add(MirAction.BeiJi, new Frame(625, 2, 0, 16));
        Monster56.Frames.Add(MirAction.Die, new Frame(641, 10, 0, 80));

        Monster57.Frames.Add(MirAction.Standing, new Frame(721, 4, 0, 32));
        Monster57.Frames.Add(MirAction.Walking, new Frame(753, 6, 0, 48));
        Monster57.Frames.Add(MirAction.Attack1, new Frame(801, 6, 0, 48));
        Monster57.Frames.Add(MirAction.BeiJi, new Frame(849, 2, 0, 16));
        Monster57.Frames.Add(MirAction.Die, new Frame(865, 10, 0, 80));

        Monster58.Frames.Add(MirAction.Standing, new Frame(945, 4, 0, 32));
        Monster58.Frames.Add(MirAction.Walking, new Frame(977, 6, 0, 48));
        Monster58.Frames.Add(MirAction.Attack1, new Frame(1025, 6, 0, 48));
        Monster58.Frames.Add(MirAction.BeiJi, new Frame(1073, 2, 0, 16));
        Monster58.Frames.Add(MirAction.Die, new Frame(1089, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon9
        Monster59.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster59.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster59.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster59.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster59.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster60.Frames.Add(MirAction.Standing, new Frame(224, 4, 0, 32));
        Monster60.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
        Monster60.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
        Monster60.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
        Monster60.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));

        Monster61.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster61.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster61.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster61.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster61.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));

        Monster62.Frames.Add(MirAction.Standing, new Frame(672, 4, 0, 32));
        Monster62.Frames.Add(MirAction.Walking, new Frame(704, 6, 0, 48));
        Monster62.Frames.Add(MirAction.Attack1, new Frame(752, 6, 0, 48));
        Monster62.Frames.Add(MirAction.Attack2, new Frame(800, 6, 0, 48));
        Monster62.Frames.Add(MirAction.BeiJi, new Frame(848, 2, 0, 16));
        Monster62.Frames.Add(MirAction.Die, new Frame(864, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon10 || E:\RXCQ\bmp\monster\mon11
        Monster63.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster63.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster63.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster63.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster63.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster64.Frames.Add(MirAction.Standing, new Frame(224, 4, 0, 32));
        Monster64.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
        Monster64.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
        Monster64.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
        Monster64.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));

        Monster65.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster65.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster65.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster65.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster65.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));

        Monster66.Frames.Add(MirAction.Standing, new Frame(672, 4, 0, 32));
        Monster66.Frames.Add(MirAction.Walking, new Frame(704, 6, 0, 48));
        Monster66.Frames.Add(MirAction.Attack1, new Frame(752, 6, 0, 48));
        Monster66.Frames.Add(MirAction.BeiJi, new Frame(800, 2, 0, 16));
        Monster66.Frames.Add(MirAction.Die, new Frame(816, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon12
        Monster67.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster67.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster67.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster67.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster67.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster68.Frames.Add(MirAction.Standing, new Frame(224, 4, 0, 32));
        Monster68.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
        Monster68.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
        Monster68.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
        Monster68.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));

        Monster69.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster69.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster69.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster69.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster69.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));

        Monster70.Frames.Add(MirAction.Standing, new Frame(672, 4, 0, 32));
        Monster70.Frames.Add(MirAction.Walking, new Frame(704, 6, 0, 48));
        Monster70.Frames.Add(MirAction.Attack1, new Frame(752, 6, 0, 48));
        Monster70.Frames.Add(MirAction.BeiJi, new Frame(800, 2, 0, 16));
        Monster70.Frames.Add(MirAction.Die, new Frame(816, 10, 0, 80));

        Monster71.Frames.Add(MirAction.Standing, new Frame(908, 4, 0, 32));
        Monster71.Frames.Add(MirAction.Walking, new Frame(940, 6, 0, 48));
        Monster71.Frames.Add(MirAction.Attack1, new Frame(988, 6, 0, 48));
        Monster71.Frames.Add(MirAction.BeiJi, new Frame(1036, 2, 0, 16));
        Monster71.Frames.Add(MirAction.Die, new Frame(1052, 10, 0, 80));

        Monster72.Frames.Add(MirAction.Standing, new Frame(1132, 4, 0, 32));
        Monster72.Frames.Add(MirAction.Walking, new Frame(1164, 6, 0, 48));
        Monster72.Frames.Add(MirAction.Attack1, new Frame(1212, 6, 0, 48));
        Monster72.Frames.Add(MirAction.BeiJi, new Frame(1260, 2, 0, 16));
        Monster72.Frames.Add(MirAction.Die, new Frame(1276, 10, 0, 80));

        Monster73.Frames.Add(MirAction.Standing, new Frame(1356, 4, 0, 32));
        Monster73.Frames.Add(MirAction.Walking, new Frame(1388, 6, 0, 48));
        Monster73.Frames.Add(MirAction.Attack1, new Frame(1436, 6, 0, 48));
        Monster73.Frames.Add(MirAction.BeiJi, new Frame(1484, 2, 0, 16));
        Monster73.Frames.Add(MirAction.Die, new Frame(1500, 10, 0, 80));

        Monster74.Frames.Add(MirAction.Standing, new Frame(1580, 4, 0, 32));
        Monster74.Frames.Add(MirAction.Walking, new Frame(1612, 6, 0, 48));
        Monster74.Frames.Add(MirAction.Attack1, new Frame(1660, 6, 0, 48));
        Monster74.Frames.Add(MirAction.BeiJi, new Frame(1708, 2, 0, 16));
        Monster74.Frames.Add(MirAction.Die, new Frame(1724, 10, 0, 80));

        Monster75.Frames.Add(MirAction.Standing, new Frame(1804, 4, 0, 32));
        Monster75.Frames.Add(MirAction.Walking, new Frame(1836, 6, 0, 48));
        Monster75.Frames.Add(MirAction.Attack1, new Frame(1884, 6, 0, 48));
        Monster75.Frames.Add(MirAction.BeiJi, new Frame(1932, 2, 0, 16));
        Monster75.Frames.Add(MirAction.Die, new Frame(1948, 10, 0, 80));

        Monster76.Frames.Add(MirAction.Standing, new Frame(2028, 4, 0, 32));
        Monster76.Frames.Add(MirAction.Walking, new Frame(2060, 6, 0, 48));
        Monster76.Frames.Add(MirAction.Attack1, new Frame(2108, 6, 0, 48));
        Monster76.Frames.Add(MirAction.BeiJi, new Frame(2156, 2, 0, 16));
        Monster76.Frames.Add(MirAction.Die, new Frame(2172, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon13
        Monster77.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster77.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster77.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster77.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster77.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster78.Frames.Add(MirAction.Standing, new Frame(224, 4, 0, 32));
        Monster78.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
        Monster78.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
        Monster78.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
        Monster78.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));

        Monster79.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster79.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster79.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster79.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster79.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));
        Monster79.Frames.Add(MirAction.Attack2, new Frame(672, 6, 0, 48));
        Monster79.Frames.Add(MirAction.Skill, new Frame(720, 8, 0, 64, false, true));
        Monster79.Frames.Add(MirAction.Skill1, new Frame(790, 8, 0, 64, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\mon14
        Monster80.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster80.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster80.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster80.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster80.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster81.Frames.Add(MirAction.Standing, new Frame(224, 12, 0, 12));
        Monster81.Frames.Add(MirAction.Die, new Frame(236, 20, 0, 20));
        Monster81.Frames.Add(MirAction.Skill, new Frame(256, 6, 0, 6));

        Monster82.Frames.Add(MirAction.Standing, new Frame(262, 12, 10, 36));
        Monster82.Frames.Add(MirAction.Die, new Frame(274, 10, 12, 30));

        Monster83.Frames.Add(MirAction.Walking, new Frame(328, 6, 0, 48));
        Monster83.Frames.Add(MirAction.Die, new Frame(376, 10, 0, 80));
        Monster83.Frames.Add(MirAction.Die1, new Frame(456, 17, 0, 17));
        #endregion

        #region E:\RXCQ\bmp\monster\mon15
        Monster84.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 4));
        Monster84.Frames.Add(MirAction.Attack1, new Frame(4, 6, 0, 6));
        Monster84.Frames.Add(MirAction.BeiJi, new Frame(10, 2, 0, 2));
        Monster84.Frames.Add(MirAction.Die, new Frame(12, 8, 0, 8));
        Monster84.Frames.Add(MirAction.Skill, new Frame(42, 10, 0, 10, false, true));

        Monster85.Frames.Add(MirAction.Standing, new Frame(52, 10, 0, 10));
        Monster85.Frames.Add(MirAction.BeiJi, new Frame(62, 12, 0, 12));
        Monster85.Frames.Add(MirAction.Die, new Frame(74, 10, 0, 10));

        Monster86.Frames.Add(MirAction.Standing, new Frame(84, 4, 0, 32));
        Monster86.Frames.Add(MirAction.Walking, new Frame(116, 6, 0, 48));
        Monster86.Frames.Add(MirAction.Attack1, new Frame(164, 6, 0, 48));
        Monster86.Frames.Add(MirAction.BeiJi, new Frame(212, 2, 0, 16));
        Monster86.Frames.Add(MirAction.Die, new Frame(228, 10, 0, 80));

        Monster87.Frames.Add(MirAction.Standing, new Frame(308, 4, 0, 32));
        Monster87.Frames.Add(MirAction.Walking, new Frame(340, 6, 0, 48));
        Monster87.Frames.Add(MirAction.Attack1, new Frame(388, 6, 0, 48));
        Monster87.Frames.Add(MirAction.BeiJi, new Frame(436, 2, 0, 16));
        Monster87.Frames.Add(MirAction.Die, new Frame(452, 10, 0, 80));

        Monster88.Frames.Add(MirAction.Standing, new Frame(532, 4, 0, 32));
        Monster88.Frames.Add(MirAction.Walking, new Frame(564, 6, 0, 48));
        Monster88.Frames.Add(MirAction.Attack1, new Frame(612, 6, 0, 48));
        Monster88.Frames.Add(MirAction.BeiJi, new Frame(660, 2, 0, 16));
        Monster88.Frames.Add(MirAction.Die, new Frame(676, 10, 0, 80));

        Monster89.Frames.Add(MirAction.Standing, new Frame(756, 4, 0, 32));
        Monster89.Frames.Add(MirAction.Walking, new Frame(788, 6, 0, 48));
        Monster89.Frames.Add(MirAction.Attack1, new Frame(836, 6, 0, 48));
        Monster89.Frames.Add(MirAction.BeiJi, new Frame(884, 2, 0, 16));
        Monster89.Frames.Add(MirAction.Die, new Frame(900, 10, 0, 80));

        Monster90.Frames.Add(MirAction.Standing, new Frame(980, 4, 0, 32));
        Monster90.Frames.Add(MirAction.Walking, new Frame(1012, 6, 0, 48));
        Monster90.Frames.Add(MirAction.Attack1, new Frame(1060, 6, 0, 48));
        Monster90.Frames.Add(MirAction.BeiJi, new Frame(1108, 2, 0, 16));
        Monster90.Frames.Add(MirAction.Die, new Frame(1124, 10, 0, 80));

        Monster91.Frames.Add(MirAction.Standing, new Frame(1204, 4, 0, 32));
        Monster91.Frames.Add(MirAction.Walking, new Frame(1236, 6, 0, 48));
        Monster91.Frames.Add(MirAction.Attack1, new Frame(1284, 6, 0, 48));
        Monster91.Frames.Add(MirAction.BeiJi, new Frame(1332, 2, 0, 16));
        Monster91.Frames.Add(MirAction.Die, new Frame(1348, 10, 0, 80));

        Monster92.Frames.Add(MirAction.Standing, new Frame(1428, 4, 0, 32));
        Monster92.Frames.Add(MirAction.Walking, new Frame(1460, 6, 0, 48));
        Monster92.Frames.Add(MirAction.Attack1, new Frame(1508, 6, 0, 48));
        Monster92.Frames.Add(MirAction.BeiJi, new Frame(1556, 2, 0, 16));
        Monster92.Frames.Add(MirAction.Die, new Frame(1572, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon16
        Monster93.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster93.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster93.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster93.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster93.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster94.Frames.Add(MirAction.Standing, new Frame(224, 4, 0, 32));
        Monster94.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
        Monster94.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
        Monster94.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
        Monster94.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));

        Monster95.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster95.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster95.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster95.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster95.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));

        Monster96.Frames.Add(MirAction.Standing, new Frame(672, 4, 0, 32));
        Monster96.Frames.Add(MirAction.Walking, new Frame(704, 6, 0, 48));
        Monster96.Frames.Add(MirAction.Attack1, new Frame(752, 6, 0, 48));
        Monster96.Frames.Add(MirAction.BeiJi, new Frame(800, 2, 0, 16));
        Monster96.Frames.Add(MirAction.Die, new Frame(816, 10, 0, 80));
        Monster96.Frames.Add(MirAction.Attack2, new Frame(896, 6, 0, 48));
        Monster96.Frames.Add(MirAction.Skill, new Frame(944, 8, 0, 64, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\mon17
        Monster97.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster97.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster97.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster97.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster97.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster98.Frames.Add(MirAction.Standing, new Frame(230, 4, 0, 32));
        Monster98.Frames.Add(MirAction.Walking, new Frame(264, 6, 0, 48));
        Monster98.Frames.Add(MirAction.Attack1, new Frame(312, 6, 0, 48));
        Monster98.Frames.Add(MirAction.BeiJi, new Frame(360, 2, 0, 16));
        Monster98.Frames.Add(MirAction.Die, new Frame(376, 10, 0, 80));

        Monster99.Frames.Add(MirAction.Standing, new Frame(464, 4, 0, 32));
        Monster99.Frames.Add(MirAction.Walking, new Frame(496, 6, 0, 48));
        Monster99.Frames.Add(MirAction.Attack1, new Frame(544, 6, 0, 48));
        Monster99.Frames.Add(MirAction.BeiJi, new Frame(592, 2, 0, 16));
        Monster99.Frames.Add(MirAction.Die, new Frame(608, 10, 0, 80));

        Monster100.Frames.Add(MirAction.Standing, new Frame(688, 4, 0, 32));
        Monster100.Frames.Add(MirAction.Walking, new Frame(720, 6, 0, 48));
        Monster100.Frames.Add(MirAction.Attack1, new Frame(768, 6, 0, 48));
        Monster100.Frames.Add(MirAction.BeiJi, new Frame(816, 2, 0, 16));
        Monster100.Frames.Add(MirAction.Die, new Frame(832, 10, 0, 80));

        Monster101.Frames.Add(MirAction.Standing, new Frame(912, 4, 0, 32));
        Monster101.Frames.Add(MirAction.Walking, new Frame(944, 6, 0, 48));
        Monster101.Frames.Add(MirAction.Attack1, new Frame(992, 6, 0, 48));
        Monster101.Frames.Add(MirAction.BeiJi, new Frame(1040, 2, 0, 16));
        Monster101.Frames.Add(MirAction.Die, new Frame(1056, 10, 0, 80));

        Monster102.Frames.Add(MirAction.Standing, new Frame(1136, 4, 0, 32));
        Monster102.Frames.Add(MirAction.Walking, new Frame(1168, 6, 0, 48));
        Monster102.Frames.Add(MirAction.Attack1, new Frame(1216, 6, 0, 48));
        Monster102.Frames.Add(MirAction.BeiJi, new Frame(1264, 2, 0, 16));
        Monster102.Frames.Add(MirAction.Die, new Frame(1280, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon18
        Monster103.Frames.Add(MirAction.Standing, new Frame(0, 10, 0, 80));
        Monster103.Frames.Add(MirAction.Standing1, new Frame(80, 4, 0, 32));
        Monster103.Frames.Add(MirAction.Walking, new Frame(112, 6, 0, 48));
        Monster103.Frames.Add(MirAction.BeiJi, new Frame(160, 2, 0, 16));
        Monster103.Frames.Add(MirAction.Die, new Frame(176, 10, 0, 80));
        Monster103.Frames.Add(MirAction.BianShen, new Frame(256, 10, 0, 80));

        Monster104.Frames.Add(MirAction.Standing, new Frame(336, 4, 0, 32));
        Monster104.Frames.Add(MirAction.Walking, new Frame(368, 6, 0, 48));
        Monster104.Frames.Add(MirAction.Attack1, new Frame(416, 6, 0, 48));
        Monster104.Frames.Add(MirAction.BeiJi, new Frame(464, 2, 0, 16));
        Monster104.Frames.Add(MirAction.Die, new Frame(480, 10, 0, 80));
        Monster104.Frames.Add(MirAction.Skill, new Frame(560, 15, 0, 15));
        Monster104.Frames.Add(MirAction.Skill1, new Frame(575, 10, 0, 10, false, true));
        Monster104.Frames.Add(MirAction.Skill2, new Frame(585, 6, 0, 48, false, true));
        Monster104.Frames.Add(MirAction.Skill3, new Frame(633, 10, 0, 10, false, true));

        Monster105.Frames.Add(MirAction.Standing, new Frame(643, 4, 0, 32, false, true));
        Monster105.Frames.Add(MirAction.Walking, new Frame(675, 6, 0, 48, false, true));
        Monster105.Frames.Add(MirAction.Attack1, new Frame(723, 6, 0, 48, false, true));
        Monster105.Frames.Add(MirAction.BeiJi, new Frame(771, 2, 0, 16, false, true));
        Monster105.Frames.Add(MirAction.Die, new Frame(787, 9, 0, 72, false, true));

        Monster106.Frames.Add(MirAction.Standing, new Frame(859, 10, 0, 10, false, true));
        Monster106.Frames.Add(MirAction.Standing1, new Frame(869, 4, 0, 32));
        Monster106.Frames.Add(MirAction.Walking, new Frame(901, 6, 0, 48));
        Monster106.Frames.Add(MirAction.Attack1, new Frame(949, 6, 0, 48));
        Monster106.Frames.Add(MirAction.BeiJi, new Frame(997, 2, 0, 16));
        Monster106.Frames.Add(MirAction.Die, new Frame(1013, 6, 0, 48));
        #endregion

        #region E:\RXCQ\bmp\monster\mon19
        Monster107.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster107.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster107.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster107.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster107.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster107.Frames.Add(MirAction.Attack2, new Frame(224, 6, 0, 48));
        Monster107.Frames.Add(MirAction.Skill, new Frame(272, 8, 0, 64, false, true));

        Monster108.Frames.Add(MirAction.Standing, new Frame(336, 4, 0, 32));
        Monster108.Frames.Add(MirAction.Walking, new Frame(368, 6, 0, 48));
        Monster108.Frames.Add(MirAction.Attack1, new Frame(416, 6, 0, 48));
        Monster108.Frames.Add(MirAction.BeiJi, new Frame(464, 2, 0, 16));
        Monster108.Frames.Add(MirAction.Die, new Frame(480, 10, 0, 80));
        Monster108.Frames.Add(MirAction.Skill, new Frame(560, 6, 0, 48, false, true));

        Monster109.Frames.Add(MirAction.Standing, new Frame(608, 4, 0, 32));
        Monster109.Frames.Add(MirAction.Walking, new Frame(640, 6, 0, 48));
        Monster109.Frames.Add(MirAction.Attack1, new Frame(688, 6, 0, 48));
        Monster109.Frames.Add(MirAction.BeiJi, new Frame(736, 2, 0, 16));
        Monster109.Frames.Add(MirAction.Die, new Frame(752, 10, 0, 80));
        Monster109.Frames.Add(MirAction.Attack2, new Frame(832, 6, 0, 48));
        Monster109.Frames.Add(MirAction.Skill, new Frame(880, 8, 0, 64, false, true));
        Monster109.Frames.Add(MirAction.Skill1, new Frame(944, 6, 0, 6, false, true));
        Monster109.Frames.Add(MirAction.Skill2, new Frame(950, 6, 0, 48, false, true));

        Monster110.Frames.Add(MirAction.Standing, new Frame(998, 4, 0, 32));
        Monster110.Frames.Add(MirAction.Walking, new Frame(1030, 6, 0, 48));
        Monster110.Frames.Add(MirAction.Attack1, new Frame(1078, 6, 0, 48));
        Monster110.Frames.Add(MirAction.BeiJi, new Frame(1126, 2, 0, 16));
        Monster110.Frames.Add(MirAction.Die, new Frame(1142, 10, 0, 80));

        Monster111.Frames.Add(MirAction.Standing, new Frame(1222, 4, 0, 32));
        Monster111.Frames.Add(MirAction.Walking, new Frame(1254, 6, 0, 48));
        Monster111.Frames.Add(MirAction.Attack1, new Frame(1302, 6, 0, 48));
        Monster111.Frames.Add(MirAction.BeiJi, new Frame(1350, 2, 0, 16));
        Monster111.Frames.Add(MirAction.Die, new Frame(1366, 10, 0, 80));

        Monster112.Frames.Add(MirAction.Standing, new Frame(1446, 4, 0, 32));
        Monster112.Frames.Add(MirAction.Walking, new Frame(1478, 6, 0, 48));
        Monster112.Frames.Add(MirAction.Attack1, new Frame(1526, 6, 0, 48));
        Monster112.Frames.Add(MirAction.BeiJi, new Frame(1574, 2, 0, 16));
        Monster112.Frames.Add(MirAction.Die, new Frame(1590, 10, 0, 80));

        Monster113.Frames.Add(MirAction.Standing, new Frame(1670, 4, 0, 32));
        Monster113.Frames.Add(MirAction.Walking, new Frame(1702, 6, 0, 48));
        Monster113.Frames.Add(MirAction.Attack1, new Frame(1750, 6, 0, 48));
        Monster113.Frames.Add(MirAction.BeiJi, new Frame(1798, 2, 0, 16));
        Monster113.Frames.Add(MirAction.Die, new Frame(1814, 10, 0, 80));

        Monster114.Frames.Add(MirAction.Standing, new Frame(1894, 4, 0, 32));
        Monster114.Frames.Add(MirAction.Walking, new Frame(1926, 6, 0, 48));
        Monster114.Frames.Add(MirAction.Attack1, new Frame(1974, 6, 0, 48));
        Monster114.Frames.Add(MirAction.BeiJi, new Frame(2022, 2, 0, 16));
        Monster114.Frames.Add(MirAction.Die, new Frame(2038, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon20
        Monster115.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster115.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster115.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster115.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster115.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster115.Frames.Add(MirAction.Skill, new Frame(224, 10, 0, 10, false, true));

        Monster116.Frames.Add(MirAction.Standing, new Frame(234, 4, 0, 32));
        Monster116.Frames.Add(MirAction.Walking, new Frame(266, 6, 0, 48));
        Monster116.Frames.Add(MirAction.Attack1, new Frame(314, 6, 0, 48));
        Monster116.Frames.Add(MirAction.BeiJi, new Frame(362, 2, 0, 16));
        Monster116.Frames.Add(MirAction.Die, new Frame(378, 10, 0, 80));
        Monster116.Frames.Add(MirAction.Skill, new Frame(458, 6, 0, 48, false, true));

        Monster117.Frames.Add(MirAction.Standing, new Frame(506, 4, 0, 32));
        Monster117.Frames.Add(MirAction.Walking, new Frame(538, 6, 0, 48));
        Monster117.Frames.Add(MirAction.Attack1, new Frame(586, 6, 0, 48));
        Monster117.Frames.Add(MirAction.BeiJi, new Frame(634, 2, 0, 16));
        Monster117.Frames.Add(MirAction.Die, new Frame(650, 10, 0, 80));
        Monster117.Frames.Add(MirAction.Skill, new Frame(730, 10, 0, 80, false, true));

        Monster118.Frames.Add(MirAction.Standing, new Frame(810, 4, 0, 32));
        Monster118.Frames.Add(MirAction.Walking, new Frame(842, 6, 0, 48));
        Monster118.Frames.Add(MirAction.Attack1, new Frame(890, 6, 0, 48));
        Monster118.Frames.Add(MirAction.BeiJi, new Frame(938, 2, 0, 16));
        Monster118.Frames.Add(MirAction.Die, new Frame(954, 10, 0, 80));
        Monster118.Frames.Add(MirAction.Skill, new Frame(1034, 8, 0, 8, false, true));

        Monster119.Frames.Add(MirAction.Standing, new Frame(1042, 4, 0, 32));
        Monster119.Frames.Add(MirAction.Walking, new Frame(1074, 6, 0, 48));
        Monster119.Frames.Add(MirAction.Attack1, new Frame(1122, 6, 0, 48));
        Monster119.Frames.Add(MirAction.BeiJi, new Frame(1170, 2, 0, 16));
        Monster119.Frames.Add(MirAction.Die, new Frame(1186, 10, 0, 80));

        Monster120.Frames.Add(MirAction.Standing, new Frame(1266, 4, 0, 32));
        Monster120.Frames.Add(MirAction.Walking, new Frame(1298, 6, 0, 48));
        Monster120.Frames.Add(MirAction.Attack1, new Frame(1346, 6, 0, 48));
        Monster120.Frames.Add(MirAction.BeiJi, new Frame(1394, 2, 0, 16));
        Monster120.Frames.Add(MirAction.Die, new Frame(1410, 10, 0, 80));

        Monster121.Frames.Add(MirAction.Standing, new Frame(1490, 4, 0, 32));
        Monster121.Frames.Add(MirAction.Walking, new Frame(1522, 6, 0, 48));
        Monster121.Frames.Add(MirAction.Attack1, new Frame(1570, 6, 0, 48));
        Monster121.Frames.Add(MirAction.ShiFa, new Frame(1618, 6, 0, 48));
        Monster121.Frames.Add(MirAction.Attack2, new Frame(1666, 6, 0, 48));
        Monster121.Frames.Add(MirAction.BeiJi, new Frame(1714, 2, 0, 16));
        Monster121.Frames.Add(MirAction.Die, new Frame(1730, 20, 0, 160));
        Monster121.Frames.Add(MirAction.Skill1, new Frame(1890, 10, 0, 80, false, true));
        Monster121.Frames.Add(MirAction.Skill, new Frame(1970, 6, 0, 48, false, true));
        Monster121.Frames.Add(MirAction.Skill2, new Frame(2018, 6, 0, 48, false, true));
        Monster121.Frames.Add(MirAction.Skill3, new Frame(2066, 6, 0, 48, false, true));
        Monster121.Frames.Add(MirAction.Skill4, new Frame(2114, 2, 0, 16, false, true));
        Monster121.Frames.Add(MirAction.Skill5, new Frame(2130, 18, 0, 144, false, true));
        Monster121.Frames.Add(MirAction.Skill6, new Frame(2274, 6, 0, 48, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\mon21
        Monster122.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster122.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster122.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster122.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster122.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster123.Frames.Add(MirAction.Standing, new Frame(224, 4, 0, 32));
        Monster123.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
        Monster123.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
        Monster123.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
        Monster123.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));

        Monster124.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster124.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster124.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster124.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster124.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));

        Monster125.Frames.Add(MirAction.Standing, new Frame(672, 4, 0, 32));
        Monster125.Frames.Add(MirAction.Walking, new Frame(704, 6, 0, 48));
        Monster125.Frames.Add(MirAction.Attack1, new Frame(752, 6, 0, 48));
        Monster125.Frames.Add(MirAction.BeiJi, new Frame(800, 2, 0, 16));
        Monster125.Frames.Add(MirAction.Die, new Frame(816, 10, 0, 80));

        Monster126.Frames.Add(MirAction.Standing, new Frame(896, 4, 0, 32));
        Monster126.Frames.Add(MirAction.Walking, new Frame(928, 6, 0, 48));
        Monster126.Frames.Add(MirAction.Attack1, new Frame(976, 6, 0, 48));
        Monster126.Frames.Add(MirAction.BeiJi, new Frame(1024, 2, 0, 16));
        Monster126.Frames.Add(MirAction.Die, new Frame(1040, 10, 0, 80));

        Monster127.Frames.Add(MirAction.Standing, new Frame(1120, 4, 0, 32));
        Monster127.Frames.Add(MirAction.Walking, new Frame(1152, 6, 0, 48));
        Monster127.Frames.Add(MirAction.Attack1, new Frame(1200, 6, 0, 48));
        Monster127.Frames.Add(MirAction.BeiJi, new Frame(1248, 2, 0, 16));
        Monster127.Frames.Add(MirAction.Die, new Frame(1264, 10, 0, 80));
        Monster127.Frames.Add(MirAction.Attack2, new Frame(1344, 6, 0, 48));
        Monster127.Frames.Add(MirAction.Skill, new Frame(1392, 3, 0, 24, false, true));
        Monster127.Frames.Add(MirAction.Skill1, new Frame(1416, 5, 0, 5, false, true));

        Monster128.Frames.Add(MirAction.Standing, new Frame(1421, 4, 0, 32));
        Monster128.Frames.Add(MirAction.Walking, new Frame(1453, 6, 0, 48));
        Monster128.Frames.Add(MirAction.Attack1, new Frame(1501, 6, 0, 48));
        Monster128.Frames.Add(MirAction.BeiJi, new Frame(1579, 2, 0, 16));
        Monster128.Frames.Add(MirAction.Die, new Frame(1565, 10, 0, 80));
        Monster128.Frames.Add(MirAction.Attack2, new Frame(1645, 6, 0, 48));
        Monster128.Frames.Add(MirAction.Skill, new Frame(1693, 3, 0, 24, false, true));
        Monster128.Frames.Add(MirAction.Skill1, new Frame(1717, 8, 0, 64, false, true));

        Monster129.Frames.Add(MirAction.Standing, new Frame(1781, 4, 0, 32));
        Monster129.Frames.Add(MirAction.Walking, new Frame(1813, 6, 0, 48));
        Monster129.Frames.Add(MirAction.Attack1, new Frame(1861, 6, 0, 48));
        Monster129.Frames.Add(MirAction.BeiJi, new Frame(1909, 2, 0, 16));
        Monster129.Frames.Add(MirAction.Die, new Frame(1925, 10, 0, 80));
        Monster129.Frames.Add(MirAction.Attack2, new Frame(2005, 6, 0, 48));
        Monster129.Frames.Add(MirAction.Skill, new Frame(2053, 6, 0, 48, false, true));
        Monster129.Frames.Add(MirAction.Skill1, new Frame(2101, 20, 0, 20, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\mon22
        Monster130.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster130.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster130.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster130.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster130.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster130.Frames.Add(MirAction.Attack2, new Frame(224, 6, 0, 48));
        Monster130.Frames.Add(MirAction.Die1, new Frame(272, 2, 0, 2));

        Monster131.Frames.Add(MirAction.Standing, new Frame(274, 4, 0, 32));
        Monster131.Frames.Add(MirAction.Walking, new Frame(306, 6, 0, 48));
        Monster131.Frames.Add(MirAction.Attack1, new Frame(354, 6, 0, 48));
        Monster131.Frames.Add(MirAction.BeiJi, new Frame(402, 2, 0, 16));
        Monster131.Frames.Add(MirAction.Die, new Frame(418, 10, 0, 80));

        Monster132.Frames.Add(MirAction.Standing, new Frame(498, 4, 0, 32));
        Monster132.Frames.Add(MirAction.Walking, new Frame(530, 6, 0, 48));
        Monster132.Frames.Add(MirAction.Attack1, new Frame(578, 6, 0, 48));
        Monster132.Frames.Add(MirAction.BeiJi, new Frame(626, 2, 0, 16));
        Monster132.Frames.Add(MirAction.Die, new Frame(642, 10, 0, 80));

        Monster133.Frames.Add(MirAction.Standing, new Frame(722, 4, 0, 32));
        Monster133.Frames.Add(MirAction.Walking, new Frame(754, 6, 0, 48));
        Monster133.Frames.Add(MirAction.Attack1, new Frame(802, 6, 0, 48));
        Monster133.Frames.Add(MirAction.BeiJi, new Frame(850, 2, 0, 16));
        Monster133.Frames.Add(MirAction.Die, new Frame(866, 10, 0, 80));

        Monster134.Frames.Add(MirAction.Standing, new Frame(946, 4, 0, 32));
        Monster134.Frames.Add(MirAction.Walking, new Frame(978, 6, 0, 48));
        Monster134.Frames.Add(MirAction.Attack1, new Frame(1026, 6, 0, 48));
        Monster134.Frames.Add(MirAction.BeiJi, new Frame(1074, 2, 0, 16));
        Monster134.Frames.Add(MirAction.Die, new Frame(1090, 10, 0, 80));

        Monster135.Frames.Add(MirAction.Standing, new Frame(1170, 4, 0, 32));
        Monster135.Frames.Add(MirAction.Walking, new Frame(1202, 6, 1, 48));
        Monster135.Frames.Add(MirAction.Attack1, new Frame(1258, 6, 1, 48));
        Monster135.Frames.Add(MirAction.BeiJi, new Frame(1314, 2, 0, 16));
        Monster135.Frames.Add(MirAction.Die, new Frame(1330, 10, 0, 80));
        Monster135.Frames.Add(MirAction.Weapon1, new Frame(1208, 1, 6, 8));
        Monster135.Frames.Add(MirAction.Weapon2, new Frame(1264, 1, 6, 8));
        Monster135.Frames.Add(MirAction.Skill, new Frame(1410, 10, 0, 10));
        Monster135.Frames.Add(MirAction.Skill1, new Frame(1420, 12, 0, 12));
        Monster135.Frames.Add(MirAction.Skill2, new Frame(1432, 30, 0, 30, false, true));
        Monster135.Frames.Add(MirAction.Skill3, new Frame(1462, 20, 0, 20, false, true));
        Monster135.Frames.Add(MirAction.Skill4, new Frame(1482, 10, 0, 10));
        Monster135.Frames.Add(MirAction.Skill5, new Frame(1492, 12, 0, 12));
        Monster135.Frames.Add(MirAction.Skill6, new Frame(1504, 30, 0, 30, false, true));
        Monster135.Frames.Add(MirAction.Skill7, new Frame(1534, 20, 0, 20, false, true));

        Monster136.Frames.Add(MirAction.Standing, new Frame(1554, 4, 0, 32));
        Monster136.Frames.Add(MirAction.Walking, new Frame(1586, 6, 0, 48));
        Monster136.Frames.Add(MirAction.Attack1, new Frame(1634, 6, 0, 48));
        Monster136.Frames.Add(MirAction.BeiJi, new Frame(1682, 2, 0, 16));
        Monster136.Frames.Add(MirAction.Die, new Frame(1698, 20, 0, 160));
        Monster136.Frames.Add(MirAction.Skill, new Frame(1858, 20, 0, 160, false, true));
        Monster136.Frames.Add(MirAction.Standing1, new Frame(2018, 20, 0, 160));
        Monster136.Frames.Add(MirAction.Skill1, new Frame(2178, 4, 0, 32, false, true));
        Monster136.Frames.Add(MirAction.Skill2, new Frame(2210, 20, 0, 20, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\mon23
        Monster137.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster137.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster137.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster137.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster137.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster137.Frames.Add(MirAction.Attack2, new Frame(224, 6, 0, 48));

        Monster138.Frames.Add(MirAction.Standing, new Frame(272, 4, 0, 32));
        Monster138.Frames.Add(MirAction.Walking, new Frame(304, 6, 0, 48));
        Monster138.Frames.Add(MirAction.Attack1, new Frame(352, 6, 0, 48));
        Monster138.Frames.Add(MirAction.BeiJi, new Frame(400, 2, 0, 16));
        Monster138.Frames.Add(MirAction.Die, new Frame(416, 10, 0, 80));
        Monster138.Frames.Add(MirAction.Attack2, new Frame(496, 6, 0, 48));
        Monster138.Frames.Add(MirAction.Standing1, new Frame(544, 6, 0, 48));

        Monster139.Frames.Add(MirAction.Standing, new Frame(782, 4, 0, 32));
        Monster139.Frames.Add(MirAction.Walking, new Frame(814, 6, 0, 48));
        Monster139.Frames.Add(MirAction.Attack1, new Frame(862, 6, 0, 48));
        Monster139.Frames.Add(MirAction.BeiJi, new Frame(910, 2, 0, 16));
        Monster139.Frames.Add(MirAction.Die, new Frame(926, 10, 0, 80));
        Monster139.Frames.Add(MirAction.Attack2, new Frame(1006, 6, 0, 48));
        Monster139.Frames.Add(MirAction.Standing1, new Frame(1054, 4, 0, 32));
        Monster139.Frames.Add(MirAction.Skill, new Frame(1086, 10, 0, 10, false, true));

        Monster140.Frames.Add(MirAction.Standing, new Frame(1096, 4, 0, 32));
        Monster140.Frames.Add(MirAction.Walking, new Frame(1128, 6, 0, 48));
        Monster140.Frames.Add(MirAction.Attack1, new Frame(1176, 6, 0, 48));
        Monster140.Frames.Add(MirAction.BeiJi, new Frame(1224, 2, 0, 16));
        Monster140.Frames.Add(MirAction.Die, new Frame(1240, 10, 0, 80));
        Monster140.Frames.Add(MirAction.Attack2, new Frame(1320, 6, 0, 48));
        Monster140.Frames.Add(MirAction.Skill, new Frame(1368, 10, 0, 80, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\mon24
        Monster141.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster141.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster141.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster141.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster141.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster142.Frames.Add(MirAction.Standing, new Frame(224, 4, 0, 32));
        Monster142.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
        Monster142.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
        Monster142.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
        Monster142.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));

        Monster143.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster143.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster143.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster143.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster143.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));
        Monster143.Frames.Add(MirAction.Attack2, new Frame(672, 6, 0, 48));
        Monster143.Frames.Add(MirAction.Skill, new Frame(720, 10, 0, 80, false, true));

        Monster144.Frames.Add(MirAction.Standing, new Frame(800, 4, 0, 32));
        Monster144.Frames.Add(MirAction.Walking, new Frame(832, 6, 0, 48));
        Monster144.Frames.Add(MirAction.Attack1, new Frame(880, 6, 0, 48));
        Monster144.Frames.Add(MirAction.BeiJi, new Frame(928, 2, 0, 16));
        Monster144.Frames.Add(MirAction.Die, new Frame(944, 10, 0, 80));
        Monster144.Frames.Add(MirAction.Attack2, new Frame(1024, 6, 0, 48));
        Monster144.Frames.Add(MirAction.Standing1, new Frame(1072, 4, 0, 32));
        Monster144.Frames.Add(MirAction.Skill, new Frame(1104, 6, 0, 48, false, true));
        Monster144.Frames.Add(MirAction.Skill1, new Frame(1152, 10, 0, 10, false, true));

        Monster145.Frames.Add(MirAction.Standing, new Frame(1162, 4, 0, 32));
        Monster145.Frames.Add(MirAction.Walking, new Frame(1194, 6, 0, 48));
        Monster145.Frames.Add(MirAction.Attack1, new Frame(1242, 6, 0, 48));
        Monster145.Frames.Add(MirAction.BeiJi, new Frame(1290, 2, 0, 16));
        Monster145.Frames.Add(MirAction.Die, new Frame(1306, 10, 0, 80));
        Monster145.Frames.Add(MirAction.Attack2, new Frame(1386, 6, 0, 48));
        Monster145.Frames.Add(MirAction.Standing1, new Frame(1434, 6, 0, 48));

        Monster146.Frames.Add(MirAction.Standing, new Frame(1672, 4, 0, 32));
        Monster146.Frames.Add(MirAction.Walking, new Frame(1704, 6, 0, 48));
        Monster146.Frames.Add(MirAction.Attack1, new Frame(1752, 6, 0, 48));
        Monster146.Frames.Add(MirAction.BeiJi, new Frame(1800, 2, 0, 16));
        Monster146.Frames.Add(MirAction.Die, new Frame(1816, 10, 0, 80));

        Monster147.Frames.Add(MirAction.Standing, new Frame(1896, 4, 0, 32));
        Monster147.Frames.Add(MirAction.Walking, new Frame(1928, 6, 0, 48));
        Monster147.Frames.Add(MirAction.Attack1, new Frame(1976, 6, 0, 48));
        Monster147.Frames.Add(MirAction.BeiJi, new Frame(2024, 2, 0, 16));
        Monster147.Frames.Add(MirAction.Die, new Frame(2040, 10, 0, 80));

        Monster148.Frames.Add(MirAction.Standing, new Frame(2120, 4, 0, 32));
        Monster148.Frames.Add(MirAction.Walking, new Frame(2152, 6, 0, 48));
        Monster148.Frames.Add(MirAction.Attack1, new Frame(2200, 6, 0, 48));
        Monster148.Frames.Add(MirAction.BeiJi, new Frame(2248, 2, 0, 16));
        Monster148.Frames.Add(MirAction.Die, new Frame(2264, 10, 0, 80));
        Monster148.Frames.Add(MirAction.Attack2, new Frame(2344, 10, 0, 80));
        Monster148.Frames.Add(MirAction.Skill, new Frame(2424, 10, 0, 10, false, true));
        Monster148.Frames.Add(MirAction.Skill1, new Frame(2434, 3, 0, 6, false, true));
        Monster148.Frames.Add(MirAction.Skill2, new Frame(2440, 10, 0, 10, false, true));
        Monster148.Frames.Add(MirAction.Standing1, new Frame(2450, 10, 0, 10));

        Monster149.Frames.Add(MirAction.Standing, new Frame(2460, 4, 0, 32));
        Monster149.Frames.Add(MirAction.Walking, new Frame(2492, 6, 0, 48));
        Monster149.Frames.Add(MirAction.Attack1, new Frame(2540, 6, 0, 48));
        Monster149.Frames.Add(MirAction.BeiJi, new Frame(2588, 2, 0, 16));
        Monster149.Frames.Add(MirAction.Die, new Frame(2604, 10, 0, 80));

        Monster150.Frames.Add(MirAction.Standing, new Frame(2684, 4, 0, 32));
        Monster150.Frames.Add(MirAction.Walking, new Frame(2716, 6, 0, 48));
        Monster150.Frames.Add(MirAction.Attack1, new Frame(2764, 6, 0, 48));
        Monster150.Frames.Add(MirAction.BeiJi, new Frame(2812, 2, 0, 16));
        Monster150.Frames.Add(MirAction.Die, new Frame(2828, 10, 0, 80));

        Monster151.Frames.Add(MirAction.Standing, new Frame(2914, 4, 0, 32));
        Monster151.Frames.Add(MirAction.Walking, new Frame(2946, 6, 0, 48));
        Monster151.Frames.Add(MirAction.Attack1, new Frame(2994, 6, 0, 48));
        Monster151.Frames.Add(MirAction.BeiJi, new Frame(3042, 2, 0, 16));
        Monster151.Frames.Add(MirAction.Die, new Frame(3058, 10, 0, 80));

        Monster152.Frames.Add(MirAction.Standing, new Frame(3138, 4, 0, 32));
        Monster152.Frames.Add(MirAction.Walking, new Frame(3170, 6, 0, 48));
        Monster152.Frames.Add(MirAction.Attack1, new Frame(3218, 6, 0, 48));
        Monster152.Frames.Add(MirAction.BeiJi, new Frame(3266, 2, 0, 16));
        Monster152.Frames.Add(MirAction.Die, new Frame(3282, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon25
        Monster153.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster153.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster153.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster153.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster153.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster153.Frames.Add(MirAction.Attack2, new Frame(224, 10, 0, 80));
        Monster153.Frames.Add(MirAction.Skill, new Frame(304, 4, 0, 32, false, true));

        Monster154.Frames.Add(MirAction.Standing, new Frame(336, 4, 0, 32));
        Monster154.Frames.Add(MirAction.Walking, new Frame(368, 6, 0, 48));
        Monster154.Frames.Add(MirAction.Attack1, new Frame(416, 6, 0, 48));
        Monster154.Frames.Add(MirAction.BeiJi, new Frame(464, 2, 0, 16));
        Monster154.Frames.Add(MirAction.Die, new Frame(480, 10, 0, 80));
        Monster154.Frames.Add(MirAction.Attack2, new Frame(560, 7, 0, 56));
        Monster154.Frames.Add(MirAction.Skill, new Frame(616, 4, 0, 32, false, true));

        Monster155.Frames.Add(MirAction.Standing, new Frame(702, 4, 0, 32));
        Monster155.Frames.Add(MirAction.Walking, new Frame(734, 6, 0, 48));
        Monster155.Frames.Add(MirAction.Attack1, new Frame(782, 6, 0, 48));
        Monster155.Frames.Add(MirAction.BeiJi, new Frame(830, 2, 0, 16));
        Monster155.Frames.Add(MirAction.Die, new Frame(846, 10, 0, 80));
        Monster155.Frames.Add(MirAction.Attack2, new Frame(926, 8, 0, 64));
        Monster155.Frames.Add(MirAction.Skill, new Frame(990, 8, 0, 64));
        Monster155.Frames.Add(MirAction.Skill1, new Frame(1054, 23, 0, 23, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\mon26
        Monster156.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster156.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster156.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster156.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster156.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster156.Frames.Add(MirAction.Attack2, new Frame(224, 10, 0, 80));
        Monster156.Frames.Add(MirAction.Skill, new Frame(304, 10, 0, 80, false, true));

        Monster157.Frames.Add(MirAction.Standing, new Frame(384, 4, 0, 32));
        Monster157.Frames.Add(MirAction.Walking, new Frame(416, 6, 0, 48));
        Monster157.Frames.Add(MirAction.Attack1, new Frame(464, 10, 0, 80));
        Monster157.Frames.Add(MirAction.BeiJi, new Frame(544, 2, 0, 16));
        Monster157.Frames.Add(MirAction.Die, new Frame(560, 9, 0, 72));
        Monster157.Frames.Add(MirAction.Attack2, new Frame(632, 6, 0, 48));
        Monster157.Frames.Add(MirAction.Skill, new Frame(680, 6, 0, 48, false, true));

        Monster158.Frames.Add(MirAction.Standing, new Frame(728, 4, 0, 32));
        Monster158.Frames.Add(MirAction.Walking, new Frame(760, 6, 0, 48));
        Monster158.Frames.Add(MirAction.Attack1, new Frame(808, 6, 0, 48));
        Monster158.Frames.Add(MirAction.BeiJi, new Frame(856, 2, 0, 16));
        Monster158.Frames.Add(MirAction.Die, new Frame(872, 8, 0, 64));

        Monster159.Frames.Add(MirAction.Standing, new Frame(936, 4, 0, 32));
        Monster159.Frames.Add(MirAction.Walking, new Frame(968, 6, 0, 48));
        Monster159.Frames.Add(MirAction.Attack1, new Frame(1016, 6, 0, 48));
        Monster159.Frames.Add(MirAction.BeiJi, new Frame(1064, 2, 0, 16));
        Monster159.Frames.Add(MirAction.Die, new Frame(1080, 8, 0, 64));

        Monster160.Frames.Add(MirAction.Standing, new Frame(1144, 4, 0, 32));
        Monster160.Frames.Add(MirAction.Walking, new Frame(1176, 6, 0, 48));
        Monster160.Frames.Add(MirAction.Attack1, new Frame(1224, 6, 0, 48));
        Monster160.Frames.Add(MirAction.BeiJi, new Frame(1272, 2, 0, 16));
        Monster160.Frames.Add(MirAction.Die, new Frame(1288, 8, 0, 64));

        Monster161.Frames.Add(MirAction.Standing, new Frame(1352, 4, 0, 32));
        Monster161.Frames.Add(MirAction.Walking, new Frame(1384, 6, 0, 48));
        Monster161.Frames.Add(MirAction.Attack1, new Frame(1432, 6, 0, 48));
        Monster161.Frames.Add(MirAction.BeiJi, new Frame(1480, 2, 0, 16));
        Monster161.Frames.Add(MirAction.Die, new Frame(1496, 8, 0, 64));
        Monster161.Frames.Add(MirAction.Attack2, new Frame(1560, 8, 0, 64));
        Monster161.Frames.Add(MirAction.Attack3, new Frame(1624, 7, 0, 56));
        Monster161.Frames.Add(MirAction.Skill, new Frame(1680, 4, 0, 32, false, true));
        Monster161.Frames.Add(MirAction.Skill1, new Frame(1712, 5, 0, 40, false, true));

        Monster162.Frames.Add(MirAction.Standing, new Frame(1752, 4, 0, 32));
        Monster162.Frames.Add(MirAction.Walking, new Frame(1784, 6, 0, 48));
        Monster162.Frames.Add(MirAction.Attack1, new Frame(1832, 6, 0, 48));
        Monster162.Frames.Add(MirAction.BeiJi, new Frame(1880, 2, 0, 16));
        Monster162.Frames.Add(MirAction.Die, new Frame(1896, 8, 0, 64));
        Monster162.Frames.Add(MirAction.Attack2, new Frame(1976, 8, 0, 64));
        Monster162.Frames.Add(MirAction.Attack3, new Frame(2040, 9, 0, 72));
        Monster162.Frames.Add(MirAction.Skill, new Frame(2112, 4, 0, 32, false, true));
        Monster162.Frames.Add(MirAction.Skill1, new Frame(2144, 6, 0, 48, false, true));
        Monster162.Frames.Add(MirAction.Skill2, new Frame(2192, 6, 0, 48, false, true));
        Monster162.Frames.Add(MirAction.Skill3, new Frame(2240, 2, 0, 16, false, true));
        Monster162.Frames.Add(MirAction.Skill4, new Frame(2256, 9, 0, 72, false, true));
        Monster162.Frames.Add(MirAction.Skill5, new Frame(2328, 8, 0, 64, false, true));
        Monster162.Frames.Add(MirAction.Skill6, new Frame(2392, 10, 0, 80, false, true));
        Monster162.Frames.Add(MirAction.Skill7, new Frame(2472, 12, 0, 12, false, true));

        Monster163.Frames.Add(MirAction.Standing, new Frame(2495, 4, 0, 32));
        Monster163.Frames.Add(MirAction.Walking, new Frame(2527, 6, 0, 48));
        Monster163.Frames.Add(MirAction.Attack1, new Frame(2575, 6, 0, 48));
        Monster163.Frames.Add(MirAction.BeiJi, new Frame(2623, 2, 0, 16));
        Monster163.Frames.Add(MirAction.Die, new Frame(2639, 7, 0, 56));

        Monster164.Frames.Add(MirAction.Standing, new Frame(2695, 4, 0, 32));
        Monster164.Frames.Add(MirAction.Walking, new Frame(2727, 6, 0, 48));
        Monster164.Frames.Add(MirAction.Attack1, new Frame(2775, 6, 0, 48));
        Monster164.Frames.Add(MirAction.BeiJi, new Frame(2823, 2, 0, 16));
        Monster164.Frames.Add(MirAction.Die, new Frame(2839, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon27
        Monster165.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster165.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster165.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster165.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster165.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster166.Frames.Add(MirAction.Standing, new Frame(224, 4, 0, 32));
        Monster166.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
        Monster166.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
        Monster166.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
        Monster166.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));

        Monster167.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster167.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster167.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster167.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster167.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));
        Monster167.Frames.Add(MirAction.Attack2, new Frame(672, 6, 0, 48));
        Monster167.Frames.Add(MirAction.Attack3, new Frame(720, 6, 0, 48));
        Monster167.Frames.Add(MirAction.Skill, new Frame(768, 6, 0, 6, false, true));

        Monster168.Frames.Add(MirAction.Standing, new Frame(774, 4, 0, 32));
        Monster168.Frames.Add(MirAction.Walking, new Frame(806, 6, 0, 48));
        Monster168.Frames.Add(MirAction.Attack1, new Frame(854, 6, 0, 48));
        Monster168.Frames.Add(MirAction.BeiJi, new Frame(902, 2, 0, 16));
        Monster168.Frames.Add(MirAction.Die, new Frame(918, 10, 0, 80));
        Monster168.Frames.Add(MirAction.Attack2, new Frame(998, 6, 0, 48));
        Monster168.Frames.Add(MirAction.Skill, new Frame(1046, 6, 0, 48, false, true));
        Monster168.Frames.Add(MirAction.Skill1, new Frame(1094, 6, 0, 48, false, true));
        Monster168.Frames.Add(MirAction.Skill2, new Frame(1142, 9, 0, 72, false, true));
        Monster168.Frames.Add(MirAction.Standing1, new Frame(1214, 6, 0, 48));
        Monster168.Frames.Add(MirAction.Standing2, new Frame(1262, 4, 0, 32));
        Monster168.Frames.Add(MirAction.Die1, new Frame(1294, 10, 0, 80));

        Monster169.Frames.Add(MirAction.Standing, new Frame(1374, 4, 0, 32));
        Monster169.Frames.Add(MirAction.Walking, new Frame(1406, 6, 0, 48));
        Monster169.Frames.Add(MirAction.Attack1, new Frame(1454, 6, 0, 48));
        Monster169.Frames.Add(MirAction.BeiJi, new Frame(1502, 2, 0, 16));
        Monster169.Frames.Add(MirAction.Die, new Frame(1518, 4, 0, 32));
        Monster169.Frames.Add(MirAction.Standing1, new Frame(1550, 12, 0, 12));
        Monster169.Frames.Add(MirAction.Skill, new Frame(1562, 6, 0, 6));
        Monster169.Frames.Add(MirAction.Skill1, new Frame(1568, 8, 0, 8));
        Monster169.Frames.Add(MirAction.Skill2, new Frame(1576, 6, 0, 6));

        Monster170.Frames.Add(MirAction.Standing, new Frame(1582, 4, 0, 32));
        Monster170.Frames.Add(MirAction.Walking, new Frame(1614, 6, 0, 48));
        Monster170.Frames.Add(MirAction.Attack1, new Frame(1662, 6, 0, 48));
        Monster170.Frames.Add(MirAction.BeiJi, new Frame(1710, 2, 0, 16));
        Monster170.Frames.Add(MirAction.Die, new Frame(1726, 10, 0, 80));
        Monster170.Frames.Add(MirAction.Attack2, new Frame(1806, 8, 0, 64));
        Monster170.Frames.Add(MirAction.Attack3, new Frame(1870, 9, 0, 72));
        Monster170.Frames.Add(MirAction.Skill, new Frame(1942, 4, 0, 32, false, true));
        Monster170.Frames.Add(MirAction.Skill1, new Frame(1974, 6, 0, 48, false, true));
        Monster170.Frames.Add(MirAction.Skill2, new Frame(2022, 6, 0, 48, false, true));
        Monster170.Frames.Add(MirAction.Skill3, new Frame(2070, 2, 0, 16, false, true));
        Monster170.Frames.Add(MirAction.Skill4, new Frame(2086, 9, 0, 72, false, true));
        Monster170.Frames.Add(MirAction.Skill5, new Frame(2158, 8, 0, 64, false, true));
        Monster170.Frames.Add(MirAction.Skill6, new Frame(2222, 10, 0, 80, false, true));
        Monster170.Frames.Add(MirAction.Skill7, new Frame(2302, 12, 0, 12, false, true));

        Monster171.Frames.Add(MirAction.Standing, new Frame(2314, 4, 0, 32));
        Monster171.Frames.Add(MirAction.Walking, new Frame(2346, 6, 0, 48));
        Monster171.Frames.Add(MirAction.Attack1, new Frame(2394, 6, 0, 48));
        Monster171.Frames.Add(MirAction.BeiJi, new Frame(2442, 2, 0, 16));
        Monster171.Frames.Add(MirAction.Die, new Frame(2458, 10, 0, 80));
        Monster171.Frames.Add(MirAction.Attack2, new Frame(2538, 8, 0, 64));
        Monster171.Frames.Add(MirAction.Attack3, new Frame(2602, 9, 0, 72));
        Monster171.Frames.Add(MirAction.Skill, new Frame(2674, 4, 0, 32, false, true));
        Monster171.Frames.Add(MirAction.Skill1, new Frame(2706, 6, 0, 48, false, true));
        Monster171.Frames.Add(MirAction.Skill2, new Frame(2754, 6, 0, 48, false, true));
        Monster171.Frames.Add(MirAction.Skill3, new Frame(2802, 2, 0, 16, false, true));
        Monster171.Frames.Add(MirAction.Skill4, new Frame(2818, 9, 0, 72, false, true));
        Monster171.Frames.Add(MirAction.Skill5, new Frame(2890, 8, 0, 64, false, true));
        Monster171.Frames.Add(MirAction.Skill6, new Frame(2954, 10, 0, 80, false, true));
        Monster171.Frames.Add(MirAction.Skill7, new Frame(3034, 12, 0, 12, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\mon28
        Monster172.Frames.Add(MirAction.Standing, new Frame(0, 10, 0, 80));
        Monster172.Frames.Add(MirAction.Standing1, new Frame(80, 4, 0, 32));
        Monster172.Frames.Add(MirAction.Walking, new Frame(112, 6, 0, 48));
        Monster172.Frames.Add(MirAction.BeiJi, new Frame(160, 2, 0, 16));
        Monster172.Frames.Add(MirAction.Die, new Frame(176, 10, 0, 80));
        Monster172.Frames.Add(MirAction.BianShen, new Frame(256, 10, 0, 80));

        Monster173.Frames.Add(MirAction.Standing, new Frame(336, 4, 0, 32));
        Monster173.Frames.Add(MirAction.Walking, new Frame(368, 6, 0, 48));
        Monster173.Frames.Add(MirAction.Attack1, new Frame(416, 6, 0, 48));
        Monster173.Frames.Add(MirAction.BeiJi, new Frame(464, 2, 0, 16));
        Monster173.Frames.Add(MirAction.Die, new Frame(480, 10, 0, 80));
        Monster173.Frames.Add(MirAction.Standing1, new Frame(560, 10, 0, 80));

        Monster174.Frames.Add(MirAction.Standing, new Frame(640, 4, 0, 32));
        Monster174.Frames.Add(MirAction.Walking, new Frame(672, 6, 0, 48));
        Monster174.Frames.Add(MirAction.BeiJi, new Frame(720, 2, 0, 16));
        Monster174.Frames.Add(MirAction.Die, new Frame(736, 10, 0, 80));
        Monster174.Frames.Add(MirAction.BianShen, new Frame(816, 10, 0, 80));

        Monster175.Frames.Add(MirAction.Standing, new Frame(896, 4, 0, 32));
        Monster175.Frames.Add(MirAction.Walking, new Frame(928, 6, 0, 48));
        Monster175.Frames.Add(MirAction.Attack1, new Frame(976, 6, 0, 48));
        Monster175.Frames.Add(MirAction.BeiJi, new Frame(1024, 2, 0, 16));
        Monster175.Frames.Add(MirAction.Die, new Frame(1040, 10, 0, 80));

        Monster176.Frames.Add(MirAction.Standing, new Frame(1120, 10, 0, 80));
        Monster176.Frames.Add(MirAction.Standing1, new Frame(1200, 4, 0, 32));
        Monster176.Frames.Add(MirAction.Walking, new Frame(1232, 6, 0, 48));
        Monster176.Frames.Add(MirAction.BeiJi, new Frame(1280, 2, 0, 16));
        Monster176.Frames.Add(MirAction.Die, new Frame(1296, 10, 0, 80));
        Monster176.Frames.Add(MirAction.BianShen, new Frame(1376, 10, 0, 80));

        Monster177.Frames.Add(MirAction.Standing, new Frame(1456, 4, 0, 32));
        Monster177.Frames.Add(MirAction.Walking, new Frame(1488, 6, 0, 48));
        Monster177.Frames.Add(MirAction.Attack1, new Frame(1536, 6, 0, 48));
        Monster177.Frames.Add(MirAction.BeiJi, new Frame(1584, 2, 0, 16));
        Monster177.Frames.Add(MirAction.Die, new Frame(1600, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon29
        Monster178.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster178.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster178.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster178.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster178.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster178.Frames.Add(MirAction.Attack2, new Frame(224, 6, 0, 48));
        Monster178.Frames.Add(MirAction.Skill, new Frame(272, 6, 0, 48, false, true));
        Monster178.Frames.Add(MirAction.Skill1, new Frame(320, 7, 0, 7, false, true));

        Monster179.Frames.Add(MirAction.Standing, new Frame(327, 4, 0, 32));
        Monster179.Frames.Add(MirAction.Walking, new Frame(359, 6, 0, 48));
        Monster179.Frames.Add(MirAction.BeiJi, new Frame(407, 2, 0, 16));
        Monster179.Frames.Add(MirAction.Die, new Frame(423, 10, 0, 80));
        Monster179.Frames.Add(MirAction.Attack1, new Frame(503, 6, 0, 48));
        Monster179.Frames.Add(MirAction.Skill, new Frame(551, 4, 0, 4));
        #endregion

        #region E:\RXCQ\bmp\monster\mon30
        Monster180.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster180.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster180.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster180.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster180.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster181.Frames.Add(MirAction.Standing, new Frame(224, 4, 0, 32));
        Monster181.Frames.Add(MirAction.Walking, new Frame(256, 6, 0, 48));
        Monster181.Frames.Add(MirAction.Attack1, new Frame(304, 6, 0, 48));
        Monster181.Frames.Add(MirAction.BeiJi, new Frame(352, 2, 0, 16));
        Monster181.Frames.Add(MirAction.Die, new Frame(368, 10, 0, 80));

        Monster182.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster182.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster182.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster182.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster182.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));

        Monster183.Frames.Add(MirAction.Standing, new Frame(672, 4, 0, 32));
        Monster183.Frames.Add(MirAction.Walking, new Frame(704, 6, 0, 48));
        Monster183.Frames.Add(MirAction.Attack1, new Frame(752, 6, 0, 48));
        Monster183.Frames.Add(MirAction.BeiJi, new Frame(800, 2, 0, 16));
        Monster183.Frames.Add(MirAction.Die, new Frame(816, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon31
        Monster184.Frames.Add(MirAction.Standing, new Frame(0, 9, 0, 72));
        Monster184.Frames.Add(MirAction.Skill, new Frame(72, 9, 0, 72, false, true));
        Monster184.Frames.Add(MirAction.Standing1, new Frame(144, 4, 0, 32));
        Monster184.Frames.Add(MirAction.Attack1, new Frame(176, 6, 0, 48));
        Monster184.Frames.Add(MirAction.BeiJi, new Frame(224, 2, 0, 16));
        Monster184.Frames.Add(MirAction.Die, new Frame(240, 10, 0, 80));
        Monster184.Frames.Add(MirAction.Skill1, new Frame(320, 6, 0, 48, false, true));
        Monster184.Frames.Add(MirAction.Skill2, new Frame(368, 10, 0, 80, false, true));

        Monster185.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster185.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster185.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster185.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster185.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));

        Monster186.Frames.Add(MirAction.Standing, new Frame(672, 4, 0, 32));
        Monster186.Frames.Add(MirAction.Walking, new Frame(704, 6, 0, 48));
        Monster186.Frames.Add(MirAction.Attack1, new Frame(752, 6, 0, 48));
        Monster186.Frames.Add(MirAction.BeiJi, new Frame(800, 2, 0, 16));
        Monster186.Frames.Add(MirAction.Die, new Frame(816, 10, 0, 80));
        Monster186.Frames.Add(MirAction.Weapon1, new Frame(896, 2, 0, 16));

        Monster187.Frames.Add(MirAction.Standing, new Frame(912, 4, 0, 32));
        Monster187.Frames.Add(MirAction.Walking, new Frame(944, 6, 0, 48));
        Monster187.Frames.Add(MirAction.Attack1, new Frame(992, 6, 0, 48));
        Monster187.Frames.Add(MirAction.BeiJi, new Frame(1040, 2, 0, 16));
        Monster187.Frames.Add(MirAction.Die, new Frame(1056, 10, 0, 80));
        Monster187.Frames.Add(MirAction.Skill, new Frame(1136, 5, 0, 40, false, true));

        Monster188.Frames.Add(MirAction.Standing, new Frame(1176, 4, 0, 32));
        Monster188.Frames.Add(MirAction.Walking, new Frame(1208, 6, 0, 48));
        Monster188.Frames.Add(MirAction.Attack1, new Frame(1256, 6, 0, 48));
        Monster188.Frames.Add(MirAction.BeiJi, new Frame(1304, 2, 0, 16));
        Monster188.Frames.Add(MirAction.Die, new Frame(1320, 10, 0, 80));
        Monster188.Frames.Add(MirAction.Weapon1, new Frame(1400, 2, 0, 16));

        Monster189.Frames.Add(MirAction.Standing, new Frame(1416, 4, 0, 32));
        Monster189.Frames.Add(MirAction.Walking, new Frame(1448, 6, 0, 48));
        Monster189.Frames.Add(MirAction.Attack1, new Frame(1496, 6, 0, 48));
        Monster189.Frames.Add(MirAction.BeiJi, new Frame(1544, 2, 0, 16));
        Monster189.Frames.Add(MirAction.Die, new Frame(1560, 10, 0, 80));
        Monster189.Frames.Add(MirAction.Skill, new Frame(1640, 3, 0, 24, false, true));

        Monster190.Frames.Add(MirAction.Standing, new Frame(1664, 4, 0, 32));
        Monster190.Frames.Add(MirAction.Walking, new Frame(1696, 6, 0, 48));
        Monster190.Frames.Add(MirAction.Attack1, new Frame(1744, 6, 0, 48));
        Monster190.Frames.Add(MirAction.BeiJi, new Frame(1792, 2, 0, 16));
        Monster190.Frames.Add(MirAction.Die, new Frame(1808, 10, 0, 80));
        Monster190.Frames.Add(MirAction.Skill, new Frame(1888, 3, 0, 24, false, true));
        Monster190.Frames.Add(MirAction.Skill1, new Frame(1912, 9, 0, 72, false, true));

        Monster191.Frames.Add(MirAction.Standing, new Frame(1984, 4, 0, 32));
        Monster191.Frames.Add(MirAction.Walking, new Frame(2016, 6, 0, 48));
        Monster191.Frames.Add(MirAction.Attack1, new Frame(2064, 6, 0, 48));
        Monster191.Frames.Add(MirAction.BeiJi, new Frame(2112, 2, 0, 16));
        Monster191.Frames.Add(MirAction.Die, new Frame(2128, 10, 0, 80));
        Monster191.Frames.Add(MirAction.Skill, new Frame(2208, 6, 0, 48, false, true));

        Monster192.Frames.Add(MirAction.Standing, new Frame(2256, 4, 0, 32));
        Monster192.Frames.Add(MirAction.Walking, new Frame(2288, 6, 0, 48));
        Monster192.Frames.Add(MirAction.Attack1, new Frame(2336, 6, 0, 48));
        Monster192.Frames.Add(MirAction.BeiJi, new Frame(2384, 2, 0, 16));
        Monster192.Frames.Add(MirAction.Die, new Frame(2400, 10, 0, 80));
        Monster192.Frames.Add(MirAction.Attack2, new Frame(2480, 6, 0, 48));
        Monster192.Frames.Add(MirAction.Skill, new Frame(2528, 6, 0, 6));
        Monster192.Frames.Add(MirAction.Skill1, new Frame(2534, 6, 0, 48, false, true));
        Monster192.Frames.Add(MirAction.Skill2, new Frame(2582, 3, 0, 3, false, true));

        Monster193.Frames.Add(MirAction.Standing, new Frame(2585, 4, 0, 32));
        Monster193.Frames.Add(MirAction.Walking, new Frame(2617, 6, 0, 48));
        Monster193.Frames.Add(MirAction.Attack1, new Frame(2665, 6, 0, 48));
        Monster193.Frames.Add(MirAction.BeiJi, new Frame(2713, 2, 0, 16));
        Monster193.Frames.Add(MirAction.Die, new Frame(2729, 10, 0, 80));

        Monster194.Frames.Add(MirAction.Standing, new Frame(2809, 4, 0, 32));
        Monster194.Frames.Add(MirAction.Walking, new Frame(2841, 6, 0, 48));
        Monster194.Frames.Add(MirAction.Attack1, new Frame(2889, 6, 0, 48));
        Monster194.Frames.Add(MirAction.BeiJi, new Frame(2937, 2, 0, 16));
        Monster194.Frames.Add(MirAction.Die, new Frame(2953, 10, 0, 80));
        Monster194.Frames.Add(MirAction.Skill, new Frame(3033, 2, 0, 16, false, true));
        Monster194.Frames.Add(MirAction.Skill1, new Frame(3049, 3, 0, 24, false, true));

        Monster195.Frames.Add(MirAction.Standing, new Frame(3073, 4, 0, 32));
        Monster195.Frames.Add(MirAction.Walking, new Frame(3105, 6, 0, 48));
        Monster195.Frames.Add(MirAction.Attack1, new Frame(3153, 6, 0, 48));
        Monster195.Frames.Add(MirAction.BeiJi, new Frame(3201, 2, 0, 16));
        Monster195.Frames.Add(MirAction.Die, new Frame(3217, 10, 0, 80));
        Monster195.Frames.Add(MirAction.Attack2, new Frame(3297, 6, 0, 48));
        Monster195.Frames.Add(MirAction.Skill, new Frame(3345, 6, 0, 48, false, true));

        Monster196.Frames.Add(MirAction.Standing, new Frame(3393, 4, 0, 32));
        Monster196.Frames.Add(MirAction.Walking, new Frame(3425, 6, 0, 48));
        Monster196.Frames.Add(MirAction.Attack1, new Frame(3473, 8, 0, 64));
        Monster196.Frames.Add(MirAction.BeiJi, new Frame(3537, 2, 0, 16));
        Monster196.Frames.Add(MirAction.Die, new Frame(3553, 16, 0, 128));
        Monster196.Frames.Add(MirAction.Attack2, new Frame(3681, 10, 0, 80));
        Monster196.Frames.Add(MirAction.Attack3, new Frame(3761, 8, 0, 64));
        Monster196.Frames.Add(MirAction.Attack4, new Frame(3825, 8, 0, 64));
        Monster196.Frames.Add(MirAction.Skill, new Frame(3889, 4, 0, 4, false, true));
        Monster196.Frames.Add(MirAction.Skill1, new Frame(3893, 4, 0, 4, false, true));
        Monster196.Frames.Add(MirAction.Skill2, new Frame(3897, 6, 0, 48, false, true));
        Monster196.Frames.Add(MirAction.Skill3, new Frame(3945, 6, 0, 48, false, true));

        Monster197.Frames.Add(MirAction.Standing, new Frame(3971, 4, 0, 32));
        Monster197.Frames.Add(MirAction.Walking, new Frame(4003, 6, 0, 48));
        Monster197.Frames.Add(MirAction.Attack1, new Frame(4051, 10, 0, 80));
        Monster197.Frames.Add(MirAction.BeiJi, new Frame(4131, 2, 0, 16));
        Monster197.Frames.Add(MirAction.Die, new Frame(4147, 14, 0, 112));
        Monster197.Frames.Add(MirAction.Attack2, new Frame(4259, 10, 0, 80));
        Monster197.Frames.Add(MirAction.Attack3, new Frame(4339, 8, 0, 64));
        Monster197.Frames.Add(MirAction.Skill, new Frame(4403, 4, 0, 32, false, true));
        Monster197.Frames.Add(MirAction.Skill1, new Frame(4435, 10, 0, 80, false, true));
        Monster197.Frames.Add(MirAction.Skill2, new Frame(4515, 10, 0, 80, false, true));
        Monster197.Frames.Add(MirAction.Skill3, new Frame(4595, 7, 0, 7, false, true));
        Monster197.Frames.Add(MirAction.Skill4, new Frame(4602, 8, 0, 64, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\mon33
        Monster198.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster198.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster198.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster198.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster198.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster198.Frames.Add(MirAction.Skill, new Frame(224, 10, 0, 10, false, true));
        Monster198.Frames.Add(MirAction.Skill1, new Frame(234, 4, 0, 32, false, true));

        Monster199.Frames.Add(MirAction.Standing, new Frame(266, 4, 0, 32));
        Monster199.Frames.Add(MirAction.Walking, new Frame(298, 6, 0, 48));
        Monster199.Frames.Add(MirAction.Attack1, new Frame(346, 6, 0, 48));
        Monster199.Frames.Add(MirAction.BeiJi, new Frame(394, 2, 0, 16));
        Monster199.Frames.Add(MirAction.Die, new Frame(410, 10, 0, 80));
        Monster199.Frames.Add(MirAction.Skill, new Frame(490, 19, 0, 19, false, true));
        Monster199.Frames.Add(MirAction.Skill1, new Frame(509, 10, 0, 10, false, true));
        Monster199.Frames.Add(MirAction.Skill2, new Frame(519, 10, 0, 10, false, true));

        Monster200.Frames.Add(MirAction.Standing, new Frame(529, 4, 0, 32));
        Monster200.Frames.Add(MirAction.Walking, new Frame(561, 6, 0, 48));
        Monster200.Frames.Add(MirAction.Attack1, new Frame(609, 6, 0, 48));
        Monster200.Frames.Add(MirAction.BeiJi, new Frame(657, 2, 0, 16));
        Monster200.Frames.Add(MirAction.Die, new Frame(673, 10, 0, 80));
        Monster200.Frames.Add(MirAction.Attack2, new Frame(753, 6, 0, 48));
        Monster200.Frames.Add(MirAction.Attack3, new Frame(801, 10, 0, 80));
        Monster200.Frames.Add(MirAction.Skill, new Frame(881, 10, 0, 10, false, true));
        Monster200.Frames.Add(MirAction.Skill1, new Frame(891, 20, 0, 20, false, true));

        Monster201.Frames.Add(MirAction.Standing, new Frame(911, 4, 0, 32));
        Monster201.Frames.Add(MirAction.Walking, new Frame(943, 6, 4, 48));
        Monster201.Frames.Add(MirAction.Weapon1, new Frame(955, 4, 6, 32));
        Monster201.Frames.Add(MirAction.Attack1, new Frame(1019, 6, 4, 48));
        Monster201.Frames.Add(MirAction.Weapon2, new Frame(1031, 4, 6, 32));
        Monster201.Frames.Add(MirAction.BeiJi, new Frame(1095, 2, 0, 16));
        Monster201.Frames.Add(MirAction.Die, new Frame(1111, 10, 0, 80));

        Monster202.Frames.Add(MirAction.Standing, new Frame(1196, 9, 0, 9));
        Monster202.Frames.Add(MirAction.Standing1, new Frame(1205, 8, 0, 8));
        Monster202.Frames.Add(MirAction.Standing2, new Frame(1213, 8, 0, 8));

        Monster203.Frames.Add(MirAction.Standing, new Frame(1221, 9, 0, 9));
        Monster203.Frames.Add(MirAction.Standing1, new Frame(1230, 8, 0, 8));
        Monster203.Frames.Add(MirAction.Standing2, new Frame(1238, 8, 0, 8));

        Monster204.Frames.Add(MirAction.Standing, new Frame(1246, 9, 0, 9));
        Monster204.Frames.Add(MirAction.Standing1, new Frame(1255, 8, 0, 8));
        Monster204.Frames.Add(MirAction.Standing2, new Frame(1263, 8, 0, 8));

        Monster205.Frames.Add(MirAction.Standing, new Frame(1271, 9, 0, 9));
        Monster205.Frames.Add(MirAction.Standing1, new Frame(1280, 8, 0, 8));
        Monster205.Frames.Add(MirAction.Standing2, new Frame(1288, 8, 0, 8));

        Monster206.Frames.Add(MirAction.Standing, new Frame(2005, 4, 0, 32));
        Monster206.Frames.Add(MirAction.Walking, new Frame(2037, 6, 4, 8));
        Monster206.Frames.Add(MirAction.Weapon1, new Frame(2043, 4, 6, 8));
        Monster206.Frames.Add(MirAction.Attack1, new Frame(2117, 6, 4, 8));
        Monster206.Frames.Add(MirAction.Weapon2, new Frame(2123, 4, 6, 8));
        Monster206.Frames.Add(MirAction.BeiJi, new Frame(2197, 2, 0, 16));
        Monster206.Frames.Add(MirAction.Die, new Frame(2213, 10, 0, 80));
        Monster206.Frames.Add(MirAction.Attack2, new Frame(2293, 6, 0, 48));

        Monster207.Frames.Add(MirAction.Standing, new Frame(2341, 4, 0, 32));
        Monster207.Frames.Add(MirAction.Walking, new Frame(2373, 6, 4, 8));
        Monster207.Frames.Add(MirAction.Weapon1, new Frame(2379, 4, 6, 8));
        Monster207.Frames.Add(MirAction.Attack1, new Frame(2453, 6, 4, 8));
        Monster207.Frames.Add(MirAction.Weapon2, new Frame(2459, 4, 6, 8));
        Monster207.Frames.Add(MirAction.BeiJi, new Frame(2533, 2, 0, 16));
        Monster207.Frames.Add(MirAction.Die, new Frame(2549, 10, 0, 80));
        Monster207.Frames.Add(MirAction.Attack2, new Frame(2629, 6, 0, 48));
        Monster207.Frames.Add(MirAction.Skill, new Frame(2677, 4, 0, 32));
        Monster207.Frames.Add(MirAction.Skill1, new Frame(2709, 12, 0, 12));

        Monster208.Frames.Add(MirAction.Standing, new Frame(2721, 4, 0, 32));
        Monster208.Frames.Add(MirAction.Walking, new Frame(2753, 6, 0, 8));
        Monster208.Frames.Add(MirAction.Attack1, new Frame(2801, 6, 0, 8));
        Monster208.Frames.Add(MirAction.BeiJi, new Frame(2849, 2, 0, 16));
        Monster208.Frames.Add(MirAction.Die, new Frame(2865, 10, 0, 80));
        Monster208.Frames.Add(MirAction.Attack2, new Frame(3009, 9, 0, 72));
        #endregion

        #region E:\RXCQ\bmp\monster\mon34
        Monster209.Frames.Add(MirAction.Standing, new Frame(12, 4, 0, 32));
        Monster209.Frames.Add(MirAction.Walking, new Frame(44, 6, 0, 48));
        Monster209.Frames.Add(MirAction.Attack1, new Frame(92, 6, 0, 48));
        Monster209.Frames.Add(MirAction.BeiJi, new Frame(140, 2, 0, 16));
        Monster209.Frames.Add(MirAction.Die, new Frame(156, 6, 0, 48));
        Monster209.Frames.Add(MirAction.Skill, new Frame(204, 4, 0, 32));
        Monster209.Frames.Add(MirAction.Skill1, new Frame(236, 6, 0, 48));
        Monster209.Frames.Add(MirAction.Skill2, new Frame(284, 2, 0, 16));
        Monster209.Frames.Add(MirAction.Skill3, new Frame(300, 6, 0, 48));
        Monster209.Frames.Add(MirAction.Skill4, new Frame(348, 6, 0, 48));

        Monster210.Frames.Add(MirAction.Standing, new Frame(396, 4, 0, 32));
        Monster210.Frames.Add(MirAction.Walking, new Frame(428, 6, 0, 48));
        Monster210.Frames.Add(MirAction.Attack1, new Frame(476, 6, 0, 48));
        Monster210.Frames.Add(MirAction.BeiJi, new Frame(524, 2, 0, 16));
        Monster210.Frames.Add(MirAction.Die, new Frame(540, 10, 0, 80));
        Monster210.Frames.Add(MirAction.Attack2, new Frame(620, 10, 0, 80));

        Monster211.Frames.Add(MirAction.Standing, new Frame(700, 4, 0, 32));
        Monster211.Frames.Add(MirAction.Walking, new Frame(732, 6, 0, 48));
        Monster211.Frames.Add(MirAction.Attack1, new Frame(780, 6, 0, 48));
        Monster211.Frames.Add(MirAction.BeiJi, new Frame(828, 2, 0, 16));
        Monster211.Frames.Add(MirAction.Die, new Frame(844, 10, 0, 80));
        Monster211.Frames.Add(MirAction.Attack2, new Frame(924, 10, 0, 80));
        Monster211.Frames.Add(MirAction.Skill, new Frame(1004, 6, 0, 48));
        Monster211.Frames.Add(MirAction.Skill1, new Frame(1052, 6, 0, 48));

        Monster212.Frames.Add(MirAction.Standing, new Frame(1127, 4, 0, 32));
        Monster212.Frames.Add(MirAction.Walking, new Frame(1159, 6, 0, 48));
        Monster212.Frames.Add(MirAction.Attack1, new Frame(1207, 6, 0, 48));
        Monster212.Frames.Add(MirAction.BeiJi, new Frame(1255, 2, 0, 16));
        Monster212.Frames.Add(MirAction.Die, new Frame(1271, 6, 0, 48));
        Monster212.Frames.Add(MirAction.Skill, new Frame(1319, 4, 0, 32));
        Monster212.Frames.Add(MirAction.Skill1, new Frame(1351, 6, 0, 48));
        Monster212.Frames.Add(MirAction.Skill2, new Frame(1399, 6, 0, 48));
        Monster212.Frames.Add(MirAction.Skill3, new Frame(1447, 2, 0, 16));
        Monster212.Frames.Add(MirAction.Skill4, new Frame(1447, 6, 0, 48));

        Monster213.Frames.Add(MirAction.Standing, new Frame(1511, 4, 0, 32));
        Monster213.Frames.Add(MirAction.Walking, new Frame(1543, 6, 0, 48));
        Monster213.Frames.Add(MirAction.Attack1, new Frame(1591, 6, 0, 48));
        Monster213.Frames.Add(MirAction.BeiJi, new Frame(1639, 2, 0, 16));
        Monster213.Frames.Add(MirAction.Die, new Frame(1655, 10, 0, 80));

        Monster214.Frames.Add(MirAction.Standing, new Frame(1735, 4, 0, 32));
        Monster214.Frames.Add(MirAction.Walking, new Frame(1767, 6, 0, 48));
        Monster214.Frames.Add(MirAction.Attack1, new Frame(1815, 6, 0, 48));
        Monster214.Frames.Add(MirAction.BeiJi, new Frame(1863, 2, 0, 16));
        Monster214.Frames.Add(MirAction.Die, new Frame(1879, 10, 0, 80));
        Monster214.Frames.Add(MirAction.Skill, new Frame(1959, 24, 0, 24));
        Monster214.Frames.Add(MirAction.Skill1, new Frame(2003, 24, 0, 24));
        #endregion

        #region E:\RXCQ\bmp\monster\mon35
        Monster215.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster215.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster215.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster215.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster215.Frames.Add(MirAction.Die, new Frame(144, 8, 0, 64));
        Monster215.Frames.Add(MirAction.Attack2, new Frame(208, 6, 0, 48));
        Monster215.Frames.Add(MirAction.Attack3, new Frame(256, 10, 0, 80));
        Monster215.Frames.Add(MirAction.Skill, new Frame(336, 7, 0, 56, false, true));

        Monster216.Frames.Add(MirAction.Skill, new Frame(392, 9, 0, 72, false, true));
        Monster216.Frames.Add(MirAction.Standing, new Frame(464, 10, 0, 80));
        Monster216.Frames.Add(MirAction.Standing1, new Frame(544, 6, 0, 48));
        Monster216.Frames.Add(MirAction.Attack1, new Frame(592, 6, 0, 48));
        Monster216.Frames.Add(MirAction.BeiJi, new Frame(640, 2, 0, 16));
        Monster216.Frames.Add(MirAction.Die, new Frame(656, 10, 0, 80));

        Monster217.Frames.Add(MirAction.Standing, new Frame(736, 10, 0, 80));
        Monster217.Frames.Add(MirAction.Standing1, new Frame(816, 6, 0, 48));
        Monster217.Frames.Add(MirAction.Attack1, new Frame(864, 6, 0, 48));
        Monster217.Frames.Add(MirAction.BeiJi, new Frame(912, 2, 0, 16));
        Monster217.Frames.Add(MirAction.Die, new Frame(928, 10, 0, 80));
        Monster217.Frames.Add(MirAction.Skill, new Frame(1008, 10, 0, 80, false, true));
        Monster217.Frames.Add(MirAction.Skill1, new Frame(1088, 6, 0, 48, false, true));
        Monster217.Frames.Add(MirAction.Skill2, new Frame(1136, 6, 0, 48, false, true));
        Monster217.Frames.Add(MirAction.Skill3, new Frame(1184, 2, 0, 16, false, true));
        Monster217.Frames.Add(MirAction.Skill4, new Frame(1200, 10, 0, 80, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\mon36
        Monster218.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster218.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster218.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster218.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster218.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));

        Monster219.Frames.Add(MirAction.Standing, new Frame(448, 4, 0, 32));
        Monster219.Frames.Add(MirAction.Walking, new Frame(480, 6, 0, 48));
        Monster219.Frames.Add(MirAction.Attack1, new Frame(528, 6, 0, 48));
        Monster219.Frames.Add(MirAction.BeiJi, new Frame(576, 2, 0, 16));
        Monster219.Frames.Add(MirAction.Die, new Frame(592, 10, 0, 80));
        Monster219.Frames.Add(MirAction.Standing1, new Frame(672, 10, 0, 80));

        Monster220.Frames.Add(MirAction.Standing, new Frame(1056, 10, 0, 10));
        Monster220.Frames.Add(MirAction.Standing1, new Frame(1066, 4, 0, 32));
        Monster220.Frames.Add(MirAction.Walking, new Frame(1098, 6, 0, 48));
        Monster220.Frames.Add(MirAction.Attack1, new Frame(1146, 6, 0, 48));
        Monster220.Frames.Add(MirAction.BeiJi, new Frame(1194, 2, 0, 16));
        Monster220.Frames.Add(MirAction.Die, new Frame(1210, 10, 0, 80));

        Monster221.Frames.Add(MirAction.Standing, new Frame(1514, 4, 0, 32));
        Monster221.Frames.Add(MirAction.Walking, new Frame(1546, 6, 0, 48));
        Monster221.Frames.Add(MirAction.Attack1, new Frame(1594, 6, 0, 48));
        Monster221.Frames.Add(MirAction.BeiJi, new Frame(1642, 2, 0, 16));
        Monster221.Frames.Add(MirAction.Die, new Frame(1658, 10, 0, 80));

        Monster222.Frames.Add(MirAction.Standing, new Frame(1962, 4, 0, 32));
        Monster222.Frames.Add(MirAction.Walking, new Frame(1994, 6, 0, 48));
        Monster222.Frames.Add(MirAction.Attack1, new Frame(2042, 6, 0, 48));
        Monster222.Frames.Add(MirAction.BeiJi, new Frame(2090, 2, 0, 16));
        Monster222.Frames.Add(MirAction.Die, new Frame(2106, 10, 0, 80));
        Monster222.Frames.Add(MirAction.Attack2, new Frame(2186, 6, 0, 48));

        Monster223.Frames.Add(MirAction.Standing, new Frame(2506, 4, 0, 32));
        Monster223.Frames.Add(MirAction.Walking, new Frame(2538, 6, 0, 48));
        Monster223.Frames.Add(MirAction.Attack1, new Frame(2586, 6, 0, 48));
        Monster223.Frames.Add(MirAction.BeiJi, new Frame(2634, 2, 0, 16));
        Monster223.Frames.Add(MirAction.Die, new Frame(2650, 10, 0, 80));

        Monster224.Frames.Add(MirAction.Standing, new Frame(2954, 4, 0, 32));
        Monster224.Frames.Add(MirAction.Walking, new Frame(2986, 6, 0, 48));
        Monster224.Frames.Add(MirAction.Attack1, new Frame(3034, 6, 0, 48));
        Monster224.Frames.Add(MirAction.BeiJi, new Frame(3082, 2, 0, 16));
        Monster224.Frames.Add(MirAction.Die, new Frame(3098, 10, 0, 80));
        Monster224.Frames.Add(MirAction.Attack2, new Frame(3178, 6, 0, 48));

        Monster225.Frames.Add(MirAction.Standing, new Frame(3498, 4, 0, 32));
        Monster225.Frames.Add(MirAction.Walking, new Frame(3530, 6, 0, 48));
        Monster225.Frames.Add(MirAction.Attack1, new Frame(3578, 6, 0, 48));
        Monster225.Frames.Add(MirAction.BeiJi, new Frame(3626, 2, 0, 16));
        Monster225.Frames.Add(MirAction.Die, new Frame(3642, 10, 0, 80));

        Monster226.Frames.Add(MirAction.Standing, new Frame(3946, 4, 0, 32));
        Monster226.Frames.Add(MirAction.Walking, new Frame(3978, 6, 0, 48));
        Monster226.Frames.Add(MirAction.Attack1, new Frame(4026, 6, 0, 48));
        Monster226.Frames.Add(MirAction.BeiJi, new Frame(4074, 2, 0, 16));
        Monster226.Frames.Add(MirAction.Die, new Frame(4090, 10, 0, 80));

        Monster227.Frames.Add(MirAction.Standing, new Frame(4394, 4, 0, 32));
        Monster227.Frames.Add(MirAction.Walking, new Frame(4426, 6, 0, 48));
        Monster227.Frames.Add(MirAction.Attack1, new Frame(4474, 6, 0, 48));
        Monster227.Frames.Add(MirAction.BeiJi, new Frame(4522, 2, 0, 16));
        Monster227.Frames.Add(MirAction.Die, new Frame(4538, 10, 0, 80));
        Monster227.Frames.Add(MirAction.Attack2, new Frame(4618, 6, 0, 48));

        Monster228.Frames.Add(MirAction.Standing, new Frame(5386, 4, 0, 32));
        Monster228.Frames.Add(MirAction.Walking, new Frame(5418, 6, 0, 48));
        Monster228.Frames.Add(MirAction.Attack1, new Frame(5466, 6, 0, 48));
        Monster228.Frames.Add(MirAction.BeiJi, new Frame(5514, 2, 0, 16));
        Monster228.Frames.Add(MirAction.Die, new Frame(5530, 10, 0, 80));

        Monster229.Frames.Add(MirAction.Standing, new Frame(6202, 4, 0, 32));
        Monster229.Frames.Add(MirAction.Walking, new Frame(6234, 6, 0, 48));
        Monster229.Frames.Add(MirAction.Attack1, new Frame(6282, 6, 0, 48));
        Monster229.Frames.Add(MirAction.BeiJi, new Frame(6330, 2, 0, 16));
        Monster229.Frames.Add(MirAction.Die, new Frame(6346, 10, 0, 80));
        Monster229.Frames.Add(MirAction.Attack2, new Frame(6426, 6, 0, 48));

        Monster230.Frames.Add(MirAction.Standing, new Frame(6746, 4, 0, 32));
        Monster230.Frames.Add(MirAction.Walking, new Frame(6778, 6, 0, 48));
        Monster230.Frames.Add(MirAction.Attack1, new Frame(6826, 6, 0, 48));
        Monster230.Frames.Add(MirAction.BeiJi, new Frame(6874, 2, 0, 16));
        Monster230.Frames.Add(MirAction.Die, new Frame(6890, 10, 0, 80));

        Monster231.Frames.Add(MirAction.Standing, new Frame(7194, 4, 0, 32));
        Monster231.Frames.Add(MirAction.Walking, new Frame(7226, 6, 0, 48));
        Monster231.Frames.Add(MirAction.Attack1, new Frame(7274, 10, 0, 80));
        Monster231.Frames.Add(MirAction.BeiJi, new Frame(7354, 2, 0, 16));
        Monster231.Frames.Add(MirAction.Die, new Frame(7370, 10, 0, 80));
        Monster231.Frames.Add(MirAction.Attack2, new Frame(7450, 10, 0, 80));

        Monster232.Frames.Add(MirAction.Standing, new Frame(7866, 4, 0, 32));
        Monster232.Frames.Add(MirAction.Walking, new Frame(7898, 6, 0, 48));
        Monster232.Frames.Add(MirAction.Attack1, new Frame(7946, 6, 0, 48));
        Monster232.Frames.Add(MirAction.BeiJi, new Frame(7994, 2, 0, 16));
        Monster232.Frames.Add(MirAction.Die, new Frame(8010, 10, 0, 80));

        Monster233.Frames.Add(MirAction.Standing, new Frame(8314, 4, 0, 32));
        Monster233.Frames.Add(MirAction.Walking, new Frame(8346, 6, 0, 48));
        Monster233.Frames.Add(MirAction.Attack1, new Frame(8394, 6, 0, 48));
        Monster233.Frames.Add(MirAction.BeiJi, new Frame(8442, 2, 0, 16));
        Monster233.Frames.Add(MirAction.Die, new Frame(8458, 10, 0, 80));

        Monster234.Frames.Add(MirAction.Standing, new Frame(8762, 4, 0, 32));
        Monster234.Frames.Add(MirAction.Walking, new Frame(8794, 6, 0, 48));
        Monster234.Frames.Add(MirAction.Attack1, new Frame(8842, 6, 0, 48));
        Monster234.Frames.Add(MirAction.BeiJi, new Frame(8890, 2, 0, 16));
        Monster234.Frames.Add(MirAction.Die, new Frame(8906, 10, 0, 80));
        Monster234.Frames.Add(MirAction.Attack2, new Frame(8986, 6, 0, 48));

        Monster235.Frames.Add(MirAction.Standing, new Frame(9306, 4, 0, 32));
        Monster235.Frames.Add(MirAction.Walking, new Frame(9338, 6, 0, 48));
        Monster235.Frames.Add(MirAction.Attack1, new Frame(9386, 6, 0, 48));
        Monster235.Frames.Add(MirAction.BeiJi, new Frame(9434, 2, 0, 16));
        Monster235.Frames.Add(MirAction.Die, new Frame(9450, 10, 0, 80));
        Monster235.Frames.Add(MirAction.Attack2, new Frame(9530, 6, 0, 48));

        Monster236.Frames.Add(MirAction.Standing, new Frame(9850, 4, 0, 32));
        Monster236.Frames.Add(MirAction.Walking, new Frame(9882, 6, 0, 48));
        Monster236.Frames.Add(MirAction.Attack1, new Frame(9930, 6, 0, 48));
        Monster236.Frames.Add(MirAction.BeiJi, new Frame(9978, 2, 0, 16));
        Monster236.Frames.Add(MirAction.Die, new Frame(9994, 10, 0, 80));
        Monster236.Frames.Add(MirAction.Attack2, new Frame(10072, 6, 0, 48));

        Monster237.Frames.Add(MirAction.Standing, new Frame(10394, 4, 0, 32));
        Monster237.Frames.Add(MirAction.Walking, new Frame(10426, 6, 0, 48));
        Monster237.Frames.Add(MirAction.Attack1, new Frame(10474, 6, 0, 48));
        Monster237.Frames.Add(MirAction.BeiJi, new Frame(10522, 2, 0, 16));
        Monster237.Frames.Add(MirAction.Die, new Frame(10538, 10, 0, 80));
        Monster237.Frames.Add(MirAction.Attack2, new Frame(10618, 6, 0, 48));

        Monster238.Frames.Add(MirAction.Standing, new Frame(10938, 4, 0, 32));
        Monster238.Frames.Add(MirAction.Walking, new Frame(10970, 6, 0, 48));
        Monster238.Frames.Add(MirAction.Attack1, new Frame(11018, 6, 0, 48));
        Monster238.Frames.Add(MirAction.BeiJi, new Frame(11066, 2, 0, 16));
        Monster238.Frames.Add(MirAction.Die, new Frame(11082, 10, 0, 80));
        Monster238.Frames.Add(MirAction.Attack2, new Frame(11162, 6, 0, 48));

        Monster239.Frames.Add(MirAction.Standing, new Frame(11482, 4, 0, 32));
        Monster239.Frames.Add(MirAction.Walking, new Frame(11514, 6, 0, 48));
        Monster239.Frames.Add(MirAction.Attack1, new Frame(11562, 6, 0, 48));
        Monster239.Frames.Add(MirAction.BeiJi, new Frame(11610, 2, 0, 16));
        Monster239.Frames.Add(MirAction.Die, new Frame(11626, 10, 0, 80));

        Monster240.Frames.Add(MirAction.Standing, new Frame(11930, 4, 0, 32));
        Monster240.Frames.Add(MirAction.Walking, new Frame(11962, 6, 0, 48));
        Monster240.Frames.Add(MirAction.Attack1, new Frame(12010, 6, 0, 48));
        Monster240.Frames.Add(MirAction.BeiJi, new Frame(12058, 2, 0, 16));
        Monster240.Frames.Add(MirAction.Die, new Frame(12074, 10, 0, 80));

        Monster241.Frames.Add(MirAction.Standing, new Frame(12378, 4, 0, 32));
        Monster241.Frames.Add(MirAction.Walking, new Frame(12410, 6, 0, 48));
        Monster241.Frames.Add(MirAction.Attack1, new Frame(12458, 9, 0, 72));
        Monster241.Frames.Add(MirAction.BeiJi, new Frame(12530, 2, 0, 16));
        Monster241.Frames.Add(MirAction.Die, new Frame(12546, 10, 0, 80));
        Monster241.Frames.Add(MirAction.Attack2, new Frame(12626, 9, 0, 72));
        Monster241.Frames.Add(MirAction.Attack3, new Frame(12698, 8, 0, 64));

        Monster242.Frames.Add(MirAction.Standing, new Frame(13146, 4, 0, 32));
        Monster242.Frames.Add(MirAction.Walking, new Frame(13178, 6, 0, 48));
        Monster242.Frames.Add(MirAction.Attack1, new Frame(13226, 6, 0, 48));
        Monster242.Frames.Add(MirAction.BeiJi, new Frame(13274, 2, 0, 16));
        Monster242.Frames.Add(MirAction.Die, new Frame(13290, 10, 0, 80));

        Monster243.Frames.Add(MirAction.Standing, new Frame(13594, 4, 0, 32));
        Monster243.Frames.Add(MirAction.Walking, new Frame(13626, 6, 0, 48));
        Monster243.Frames.Add(MirAction.Attack1, new Frame(13674, 6, 0, 48));
        Monster243.Frames.Add(MirAction.BeiJi, new Frame(13722, 2, 0, 16));
        Monster243.Frames.Add(MirAction.Die, new Frame(13738, 10, 0, 80));
        Monster243.Frames.Add(MirAction.Attack2, new Frame(13818, 6, 0, 48));
        Monster243.Frames.Add(MirAction.Standing1, new Frame(13866, 10, 0, 80));

        Monster244.Frames.Add(MirAction.Standing, new Frame(14298, 4, 0, 32));
        Monster244.Frames.Add(MirAction.Walking, new Frame(14330, 6, 0, 48));
        Monster244.Frames.Add(MirAction.Attack1, new Frame(14378, 6, 0, 48));
        Monster244.Frames.Add(MirAction.BeiJi, new Frame(14426, 2, 0, 16));
        Monster244.Frames.Add(MirAction.Die, new Frame(14442, 10, 0, 80));
        Monster244.Frames.Add(MirAction.Standing1, new Frame(14746, 5, 0, 15));

        Monster245.Frames.Add(MirAction.Standing, new Frame(4938, 4, 0, 32));
        Monster245.Frames.Add(MirAction.Walking, new Frame(4970, 6, 0, 48));
        Monster245.Frames.Add(MirAction.Attack1, new Frame(5018, 6, 0, 48));
        Monster245.Frames.Add(MirAction.BeiJi, new Frame(5066, 2, 0, 16));
        Monster245.Frames.Add(MirAction.Die, new Frame(5082, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon37
        Monster246.Frames.Add(MirAction.Standing, new Frame(0, 6, 0, 48));
        Monster246.Frames.Add(MirAction.Walking, new Frame(48, 6, 0, 48));
        Monster246.Frames.Add(MirAction.Attack1, new Frame(96, 9, 0, 72));
        Monster246.Frames.Add(MirAction.BeiJi, new Frame(168, 3, 0, 25));
        Monster246.Frames.Add(MirAction.Die, new Frame(192, 9, 0, 72));

        Monster247.Frames.Add(MirAction.Standing, new Frame(264, 9, 0, 72));
        Monster247.Frames.Add(MirAction.Walking, new Frame(336, 7, 0, 56));
        Monster247.Frames.Add(MirAction.Attack1, new Frame(392, 8, 0, 64));
        Monster247.Frames.Add(MirAction.Attack2, new Frame(456, 10, 0, 80));
        Monster247.Frames.Add(MirAction.Attack3, new Frame(536, 10, 0, 80));
        Monster247.Frames.Add(MirAction.BeiJi, new Frame(616, 3, 0, 24));
        Monster247.Frames.Add(MirAction.Die, new Frame(640, 10, 0, 80));

        Monster248.Frames.Add(MirAction.Standing, new Frame(720, 6, 0, 48));
        Monster248.Frames.Add(MirAction.Walking, new Frame(768, 6, 0, 48));
        Monster248.Frames.Add(MirAction.Attack1, new Frame(816, 8, 0, 64));
        Monster248.Frames.Add(MirAction.BeiJi, new Frame(880, 3, 0, 24));
        Monster248.Frames.Add(MirAction.Die, new Frame(904, 8, 0, 64));

        Monster249.Frames.Add(MirAction.Standing, new Frame(1016, 5, 0, 40));
        Monster249.Frames.Add(MirAction.Walking, new Frame(1056, 6, 0, 48));
        Monster249.Frames.Add(MirAction.Attack1, new Frame(1104, 8, 0, 64));
        Monster249.Frames.Add(MirAction.BeiJi, new Frame(1168, 3, 0, 24));
        Monster249.Frames.Add(MirAction.Die, new Frame(1192, 7, 0, 56));

        Monster250.Frames.Add(MirAction.Standing, new Frame(1248, 7, 0, 56));
        Monster250.Frames.Add(MirAction.Walking, new Frame(1304, 6, 0, 48));
        Monster250.Frames.Add(MirAction.Attack1, new Frame(1352, 7, 0, 56));
        Monster250.Frames.Add(MirAction.BeiJi, new Frame(1408, 3, 0, 24));
        Monster250.Frames.Add(MirAction.Die, new Frame(1432, 7, 0, 56));

        Monster251.Frames.Add(MirAction.Standing, new Frame(1488, 9, 0, 72));
        Monster251.Frames.Add(MirAction.Walking, new Frame(1560, 6, 0, 48));
        Monster251.Frames.Add(MirAction.Attack2, new Frame(1672, 6, 0, 48));
        Monster251.Frames.Add(MirAction.Attack3, new Frame(1720, 7, 0, 56));
        Monster251.Frames.Add(MirAction.BeiJi, new Frame(1776, 4, 0, 32));
        Monster251.Frames.Add(MirAction.Die, new Frame(1808, 7, 0, 56));
        Monster251.Frames.Add(MirAction.Skill, new Frame(1864, 7, 0, 7));

        Monster252.Frames.Add(MirAction.Standing, new Frame(1889, 6, 0, 48));
        Monster252.Frames.Add(MirAction.Walking, new Frame(1937, 6, 0, 48));
        Monster252.Frames.Add(MirAction.Attack1, new Frame(1985, 10, 0, 80));
        Monster252.Frames.Add(MirAction.Attack2, new Frame(2065, 10, 0, 80));
        Monster252.Frames.Add(MirAction.Standing1, new Frame(2145, 10, 0, 80));
        Monster252.Frames.Add(MirAction.BeiJi, new Frame(2225, 10, 0, 80));
        #endregion

        #region E:\RXCQ\bmp\monster\mon38 用的mon32的帧序列
        #endregion

        #region E:\RXCQ\bmp\monster\mon39
        Monster254.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster254.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster254.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster254.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster254.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster254.Frames.Add(MirAction.Skill, new Frame(224, 4, 0, 32, false, true));
        Monster254.Frames.Add(MirAction.Skill1, new Frame(256, 6, 0, 48, false, true));
        Monster254.Frames.Add(MirAction.Skill2, new Frame(304, 6, 0, 48, false, true));
        Monster254.Frames.Add(MirAction.Skill3, new Frame(352, 2, 0, 16, false, true));
        Monster254.Frames.Add(MirAction.Skill4, new Frame(368, 10, 0, 80, false, true));
        Monster254.Frames.Add(MirAction.Skill5, new Frame(448, 10, 0, 10, false, true));

        Monster255.Frames.Add(MirAction.Standing, new Frame(458, 4, 0, 32));
        Monster255.Frames.Add(MirAction.Walking, new Frame(490, 6, 0, 48));
        Monster255.Frames.Add(MirAction.Attack1, new Frame(538, 6, 0, 48));
        Monster255.Frames.Add(MirAction.BeiJi, new Frame(586, 2, 0, 16));
        Monster255.Frames.Add(MirAction.Die, new Frame(602, 10, 0, 80));
        Monster255.Frames.Add(MirAction.Skill, new Frame(682, 4, 0, 32, false, true));
        Monster255.Frames.Add(MirAction.Skill1, new Frame(714, 6, 0, 48, false, true));
        Monster255.Frames.Add(MirAction.Skill2, new Frame(762, 6, 0, 48, false, true));
        Monster255.Frames.Add(MirAction.Skill3, new Frame(810, 2, 0, 16, false, true));
        Monster255.Frames.Add(MirAction.Skill4, new Frame(826, 10, 0, 80, false, true));
        Monster255.Frames.Add(MirAction.Skill5, new Frame(906, 10, 0, 10, false, true));

        Monster256.Frames.Add(MirAction.Standing, new Frame(916, 4, 0, 32));
        Monster256.Frames.Add(MirAction.Walking, new Frame(948, 6, 0, 48));
        Monster256.Frames.Add(MirAction.Attack1, new Frame(996, 6, 0, 48));
        Monster256.Frames.Add(MirAction.BeiJi, new Frame(1044, 2, 0, 16));
        Monster256.Frames.Add(MirAction.Die, new Frame(1060, 10, 0, 80));
        Monster256.Frames.Add(MirAction.Skill, new Frame(1140, 4, 0, 32, false, true));
        Monster256.Frames.Add(MirAction.Skill1, new Frame(1172, 6, 0, 48, false, true));
        Monster256.Frames.Add(MirAction.Skill2, new Frame(1220, 6, 0, 48, false, true));
        Monster256.Frames.Add(MirAction.Skill3, new Frame(1268, 2, 0, 16, false, true));
        Monster256.Frames.Add(MirAction.Skill4, new Frame(1284, 10, 0, 80, false, true));
        Monster256.Frames.Add(MirAction.Skill5, new Frame(1364, 10, 0, 10, false, true));

        Monster257.Frames.Add(MirAction.Standing, new Frame(916 + 458, 4, 0, 32));
        Monster257.Frames.Add(MirAction.Walking, new Frame(948 + 458, 6, 0, 48));
        Monster257.Frames.Add(MirAction.Attack1, new Frame(996 + 458, 6, 0, 48));
        Monster257.Frames.Add(MirAction.BeiJi, new Frame(1044 + 458, 2, 0, 16));
        Monster257.Frames.Add(MirAction.Die, new Frame(1060 + 458, 10, 0, 80));
        Monster257.Frames.Add(MirAction.Skill, new Frame(1140 + 458, 4, 0, 32, false, true));
        Monster257.Frames.Add(MirAction.Skill1, new Frame(1172 + 458, 6, 0, 48, false, true));
        Monster257.Frames.Add(MirAction.Skill2, new Frame(1220 + 458, 6, 0, 48, false, true));
        Monster257.Frames.Add(MirAction.Skill3, new Frame(1268 + 458, 2, 0, 16, false, true));
        Monster257.Frames.Add(MirAction.Skill4, new Frame(1284 + 458, 10, 0, 80, false, true));
        Monster257.Frames.Add(MirAction.Skill5, new Frame(1364 + 458, 10, 0, 10, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\mon40
        Monster258.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster258.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster258.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster258.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster258.Frames.Add(MirAction.Die, new Frame(144, 10, 0, 80));
        Monster258.Frames.Add(MirAction.Attack2, new Frame(224, 6, 0, 48));
        Monster258.Frames.Add(MirAction.Skill, new Frame(272, 3, 0, 24, false, true));
        Monster258.Frames.Add(MirAction.Skill1, new Frame(296, 6, 0, 48, false, true));
        Monster258.Frames.Add(MirAction.Skill2, new Frame(344, 5, 0, 5, false, true));

        Monster259.Frames.Add(MirAction.Standing, new Frame(349, 4, 0, 32));
        Monster259.Frames.Add(MirAction.Walking, new Frame(381, 6, 0, 48));
        Monster259.Frames.Add(MirAction.Attack1, new Frame(429, 6, 0, 48));
        Monster259.Frames.Add(MirAction.BeiJi, new Frame(477, 2, 0, 16));
        Monster259.Frames.Add(MirAction.Die, new Frame(493, 10, 0, 80));
        Monster259.Frames.Add(MirAction.Attack2, new Frame(573, 6, 0, 48));
        Monster259.Frames.Add(MirAction.Skill, new Frame(621, 6, 0, 48));
        Monster259.Frames.Add(MirAction.Skill1, new Frame(669, 9, 0, 9));

        Monster260.Frames.Add(MirAction.Standing, new Frame(950, 4, 0, 32));
        Monster260.Frames.Add(MirAction.Walking, new Frame(982, 6, 0, 48));
        Monster260.Frames.Add(MirAction.Attack1, new Frame(1030, 6, 0, 48));
        Monster260.Frames.Add(MirAction.BeiJi, new Frame(1078, 2, 0, 16));
        Monster260.Frames.Add(MirAction.Die, new Frame(1094, 10, 0, 80));
        Monster260.Frames.Add(MirAction.Attack2, new Frame(1174, 6, 0, 48));

        Monster261.Frames.Add(MirAction.Attack1, new Frame(1528, 6, 0, 48));
        Monster261.Frames.Add(MirAction.Walking, new Frame(1576, 6, 0, 48));
        Monster261.Frames.Add(MirAction.Attack2, new Frame(1624, 6, 0, 48));
        Monster261.Frames.Add(MirAction.BeiJi, new Frame(1672, 2, 0, 16));
        Monster261.Frames.Add(MirAction.Die, new Frame(1688, 8, 0, 64));

        Monster262.Frames.Add(MirAction.Standing, new Frame(1752, 4, 0, 32));
        Monster262.Frames.Add(MirAction.Walking, new Frame(1784, 6, 0, 48));
        Monster262.Frames.Add(MirAction.Attack1, new Frame(1832, 6, 0, 48));
        Monster262.Frames.Add(MirAction.BeiJi, new Frame(1880, 2, 0, 16));
        Monster262.Frames.Add(MirAction.Die, new Frame(1896, 10, 0, 80));
        Monster262.Frames.Add(MirAction.Attack2, new Frame(1976, 8, 0, 64));
        Monster262.Frames.Add(MirAction.Attack3, new Frame(2040, 9, 0, 72));
        Monster262.Frames.Add(MirAction.Skill, new Frame(2112, 8, 0, 8, false, true));
        Monster262.Frames.Add(MirAction.Skill1, new Frame(2120, 8, 0, 8, false, true));
        Monster262.Frames.Add(MirAction.Skill2, new Frame(2120, 10, 0, 10, false, true));

        Monster263.Frames.Add(MirAction.Standing, new Frame(2498, 4, 0, 32));
        Monster263.Frames.Add(MirAction.Walking, new Frame(2530, 6, 0, 48));
        Monster263.Frames.Add(MirAction.Attack1, new Frame(2578, 6, 0, 48));
        Monster263.Frames.Add(MirAction.BeiJi, new Frame(2626, 2, 0, 16));
        Monster263.Frames.Add(MirAction.Die, new Frame(2642, 10, 0, 80));
        Monster263.Frames.Add(MirAction.Attack2, new Frame(2722, 8, 0, 64));
        Monster263.Frames.Add(MirAction.Skill, new Frame(2791, 8, 0, 8, false, true));

        Monster264.Frames.Add(MirAction.Standing, new Frame(2799, 4, 0, 32));
        Monster264.Frames.Add(MirAction.Walking, new Frame(2831, 6, 0, 48));
        Monster264.Frames.Add(MirAction.Attack1, new Frame(2879, 6, 0, 48));
        Monster264.Frames.Add(MirAction.BeiJi, new Frame(2927, 2, 0, 16));
        Monster264.Frames.Add(MirAction.Die, new Frame(2943, 8, 0, 64));
        Monster264.Frames.Add(MirAction.Skill, new Frame(3007, 8, 0, 8, false, true));

        Monster265.Frames.Add(MirAction.Standing, new Frame(3015, 4, 0, 32));
        Monster265.Frames.Add(MirAction.Walking, new Frame(3048, 6, 0, 48));
        Monster265.Frames.Add(MirAction.Attack1, new Frame(3095, 6, 0, 48));
        Monster265.Frames.Add(MirAction.BeiJi, new Frame(3143, 2, 0, 16));
        Monster265.Frames.Add(MirAction.Die, new Frame(3159, 8, 0, 64));
        Monster265.Frames.Add(MirAction.Attack2, new Frame(3239, 6, 0, 48));
        Monster265.Frames.Add(MirAction.Attack3, new Frame(3287, 10, 0, 80));
        Monster265.Frames.Add(MirAction.Attack4, new Frame(3367, 7, 0, 56));
        Monster265.Frames.Add(MirAction.Attack5, new Frame(3423, 7, 0, 56));
        Monster265.Frames.Add(MirAction.Skill, new Frame(3479, 2, 0, 16, false, true));
        Monster265.Frames.Add(MirAction.Skill1, new Frame(3495, 5, 0, 5, false, true));
        Monster265.Frames.Add(MirAction.Skill2, new Frame(3500, 9, 0, 9, false, true));
        Monster265.Frames.Add(MirAction.Skill3, new Frame(3509, 7, 0, 56, false, true));
        Monster265.Frames.Add(MirAction.Skill4, new Frame(3565, 10, 0, 10, false, true));
        Monster265.Frames.Add(MirAction.Skill5, new Frame(3575, 10, 0, 10));
        Monster265.Frames.Add(MirAction.Skill6, new Frame(3585, 9, 0, 9));
        Monster265.Frames.Add(MirAction.Skill7, new Frame(3613, 5, 0, 40));
        #endregion

        #region E:\RXCQ\bmp\monster\mon41
        Monster266.Frames.Add(MirAction.Standing, new Frame(0, 10, 0, 10));
        Monster266.Frames.Add(MirAction.Standing1, new Frame(10, 6, 0, 48));
        Monster266.Frames.Add(MirAction.Walking, new Frame(58, 6, 0, 48));
        Monster266.Frames.Add(MirAction.Attack1, new Frame(106, 6, 0, 48));
        Monster266.Frames.Add(MirAction.BeiJi, new Frame(154, 2, 0, 16));
        Monster266.Frames.Add(MirAction.Die, new Frame(170, 10, 0, 80));

        Monster267.Frames.Add(MirAction.Standing, new Frame(250, 10, 0, 80));
        Monster267.Frames.Add(MirAction.BianShen, new Frame(330, 10, 0, 80));
        Monster267.Frames.Add(MirAction.Standing1, new Frame(410, 6, 0, 48));
        Monster267.Frames.Add(MirAction.Walking, new Frame(458, 6, 0, 48));
        Monster267.Frames.Add(MirAction.BeiJi, new Frame(506, 2, 0, 16));
        Monster267.Frames.Add(MirAction.Die, new Frame(522, 10, 0, 80));

        Monster268.Frames.Add(MirAction.Standing, new Frame(602, 6, 0, 48));
        Monster268.Frames.Add(MirAction.Walking, new Frame(650, 6, 0, 48));
        Monster268.Frames.Add(MirAction.Attack1, new Frame(698, 6, 0, 48));
        Monster268.Frames.Add(MirAction.BeiJi, new Frame(746, 2, 0, 16));
        Monster268.Frames.Add(MirAction.Die, new Frame(762, 10, 0, 80));
        Monster268.Frames.Add(MirAction.Skill, new Frame(842, 6, 0, 48));
        Monster268.Frames.Add(MirAction.Skill1, new Frame(890, 30, 0, 30));
        Monster268.Frames.Add(MirAction.Skill2, new Frame(920, 30, 0, 30, false, true));
        Monster268.Frames.Add(MirAction.Skill3, new Frame(950, 17, 0, 17, false, true));
        #endregion

        #region E:\RXCQ\bmp\monster\Mon-kulou
        Monster269.Frames.Add(MirAction.Standing, new Frame(0, 4, 0, 32));
        Monster269.Frames.Add(MirAction.Walking, new Frame(32, 6, 0, 48));
        Monster269.Frames.Add(MirAction.Attack1, new Frame(80, 6, 0, 48));
        Monster269.Frames.Add(MirAction.BeiJi, new Frame(128, 2, 0, 16));
        Monster269.Frames.Add(MirAction.Die, new Frame(144, 6, 0, 48));
        Monster269.Frames.Add(MirAction.Standing1, new Frame(192, 5, 0, 5));

        Monster270.Frames.Add(MirAction.Standing, new Frame(197, 4, 0, 32));
        Monster270.Frames.Add(MirAction.Walking, new Frame(229, 6, 0, 48));
        Monster270.Frames.Add(MirAction.Attack1, new Frame(277, 6, 0, 48));
        Monster270.Frames.Add(MirAction.BeiJi, new Frame(325, 2, 0, 16));
        Monster270.Frames.Add(MirAction.Die, new Frame(341, 6, 0, 48));
        Monster270.Frames.Add(MirAction.Standing1, new Frame(389, 5, 0, 5));

        Monster271.Frames.Add(MirAction.Standing, new Frame(394, 4, 0, 32));
        Monster271.Frames.Add(MirAction.Walking, new Frame(426, 6, 0, 48));
        Monster271.Frames.Add(MirAction.Attack1, new Frame(474, 6, 0, 48));
        Monster271.Frames.Add(MirAction.BeiJi, new Frame(522, 2, 0, 16));
        Monster271.Frames.Add(MirAction.Die, new Frame(538, 6, 0, 48));
        #endregion

        #endregion

        #region Effect
        #region E:\RXCQ\bmp\magic\Magic
        Effect.EffectFrames.Add(new Frame(0, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(10, 6, 14, 96, false, true));
        Effect.EffectFrames.Add(new Frame(170, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(200, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(250, 20, 0, 20, false, true));
        Effect.EffectFrames.Add(new Frame(370, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(600, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(610, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(760, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(770, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(400, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(410, 6, 14, 96, false, true));
        Effect.EffectFrames.Add(new Frame(570, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(800, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(880, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(900, 6, 0, 6, false, true));
        Effect.EffectFrames.Add(new Frame(920, 16, 0, 16, false, true));
        Effect.EffectFrames.Add(new Frame(950, 6, 0, 6, false, true));
        Effect.EffectFrames.Add(new Frame(970, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(1140, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(1160, 3, 0, 3, false, true));
        Effect.EffectFrames.Add(new Frame(1170, 3, 7, 24, false, true));
        Effect.EffectFrames.Add(new Frame(1340, 16, 0, 16, false, true));
        Effect.EffectFrames.Add(new Frame(1360, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(1380, 30, 0, 30, false, true));
        Effect.EffectFrames.Add(new Frame(1410, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(1500, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(1520, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(1540, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(1560, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(1570, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(1590, 20, 0, 20, false, true));
        Effect.EffectFrames.Add(new Frame(1620, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(1630, 6, 0, 6, false, true));
        Effect.EffectFrames.Add(new Frame(1650, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(1660, 20, 0, 20, false, true));
        Effect.EffectFrames.Add(new Frame(1680, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(1700, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(1790, 20, 0, 20, false, true));
        Effect.EffectFrames.Add(new Frame(1820, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(1910, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(2000, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(2090, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(2190, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(2280, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(2370, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(2460, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(2560, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(2650, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(2740, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(2830, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(2930, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(3020, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(3110, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(3200, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(3300, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(3390, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(3480, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(3570, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(3660, 6, 4, 48, false, true));
        Effect.EffectFrames.Add(new Frame(3750, 5, 5, 40, false, true));
        Effect.EffectFrames.Add(new Frame(3840, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(3850, 20, 0, 20, false, true));
        Effect.EffectFrames.Add(new Frame(3880, 13, 0, 13, false, true));
        Effect.EffectFrames.Add(new Frame(3900, 3, 0, 3, false, true));
        Effect.EffectFrames.Add(new Frame(3920, 10, 0, 10, false, true));
        Effect.EffectFrames.Add(new Frame(3930, 16, 0, 16, false, true));
        Effect.EffectFrames.Add(new Frame(3960, 20, 0, 20, false, true));
        Effect.EffectFrames.Add(new Frame(3990, 10, 0, 10, false, true));
        #endregion

        #region E:\RXCQ\bmp\magic\magic2
        Effect1.EffectFrames.Add(new Frame(0, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(10, 5, 0, 5, false, true));
        Effect1.EffectFrames.Add(new Frame(20, 3, 0, 3, false, true));
        Effect1.EffectFrames.Add(new Frame(40, 6, 4, 48, false, true));
        Effect1.EffectFrames.Add(new Frame(130, 6, 0, 6, false, true));
        Effect1.EffectFrames.Add(new Frame(140, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(160, 15, 0, 15, false, true));
        Effect1.EffectFrames.Add(new Frame(190, 6, 0, 6, false, true));
        Effect1.EffectFrames.Add(new Frame(210, 6, 0, 6, false, true));
        Effect1.EffectFrames.Add(new Frame(220, 12, 8, 96, false, true));
        Effect1.EffectFrames.Add(new Frame(380, 6, 0, 6, false, true));
        Effect1.EffectFrames.Add(new Frame(400, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(410, 4, 6, 32, false, true));
        Effect1.EffectFrames.Add(new Frame(570, 8, 0, 8, false, true));
        Effect1.EffectFrames.Add(new Frame(580, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(600, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(620, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(633, 8, 0, 8, false, true));
        Effect1.EffectFrames.Add(new Frame(650, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(670, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(690, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(710, 20, 0, 20, false, true));
        Effect1.EffectFrames.Add(new Frame(740, 15, 5, 120, false, true));
        Effect1.EffectFrames.Add(new Frame(910, 23, 0, 23, false, true));
        Effect1.EffectFrames.Add(new Frame(950, 24, 0, 24, false, true));
        Effect1.EffectFrames.Add(new Frame(990, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(1010, 18, 0, 18, false, true));
        Effect1.EffectFrames.Add(new Frame(1040, 7, 0, 7, false, true));
        Effect1.EffectFrames.Add(new Frame(1060, 20, 0, 20, false, true));
        Effect1.EffectFrames.Add(new Frame(1090, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(1110, 10, 0, 10, false, true));
        Effect1.EffectFrames.Add(new Frame(1130, 7, 0, 7, false, true));
        Effect1.EffectFrames.Add(new Frame(1150, 20, 0, 20, false, true));
        Effect1.EffectFrames.Add(new Frame(1180, 10, 0, 10, false, true));
        #endregion

        #region E:\RXCQ\bmp\magic\magic3
        Effect2.EffectFrames.Add(new Frame(0, 14, 0, 14, false, true));
        Effect2.EffectFrames.Add(new Frame(20, 10, 0, 10, false, true));
        Effect2.EffectFrames.Add(new Frame(40, 10, 0, 10, false, true));
        Effect2.EffectFrames.Add(new Frame(60, 20, 0, 20, false, true));
        Effect2.EffectFrames.Add(new Frame(80, 20, 0, 20, false, true));
        Effect2.EffectFrames.Add(new Frame(100, 16, 0, 16, false, true));
        Effect2.EffectFrames.Add(new Frame(120, 16, 0, 16, false, true));
        Effect2.EffectFrames.Add(new Frame(140, 16, 0, 16, false, true));
        Effect2.EffectFrames.Add(new Frame(160, 16, 0, 16, false, true));
        Effect2.EffectFrames.Add(new Frame(180, 16, 0, 16, false, true));
        Effect2.EffectFrames.Add(new Frame(200, 20, 0, 20, false, true));
        #endregion

        #region E:\RXCQ\bmp\magic\magic4
        Effect3.EffectFrames.Add(new Frame(0, 17, 3, 136, false, true));
        Effect3.EffectFrames.Add(new Frame(170, 5, 0, 5, false, true));
        Effect3.EffectFrames.Add(new Frame(180, 6, 0, 6, false, true));
        Effect3.EffectFrames.Add(new Frame(190, 10, 0, 10, false, true));
        Effect3.EffectFrames.Add(new Frame(210, 10, 0, 10, false, true));
        Effect3.EffectFrames.Add(new Frame(230, 27, 0, 27, false, true));
        Effect3.EffectFrames.Add(new Frame(260, 8, 0, 8, false, true));
        Effect3.EffectFrames.Add(new Frame(270, 10, 0, 10, false, true));
        Effect3.EffectFrames.Add(new Frame(290, 10, 0, 10, false, true));
        Effect3.EffectFrames.Add(new Frame(310, 6, 4, 48, false, true));
        Effect3.EffectFrames.Add(new Frame(390, 25, 0, 25, false, true));
        Effect3.EffectFrames.Add(new Frame(420, 16, 0, 16, false, true));
        Effect3.EffectFrames.Add(new Frame(440, 10, 0, 10, false, true));
        Effect3.EffectFrames.Add(new Frame(460, 10, 0, 10, false, true));
        Effect3.EffectFrames.Add(new Frame(495, 24, 0, 24, false, true));
        Effect3.EffectFrames.Add(new Frame(520, 16, 0, 16, false, true));
        Effect3.EffectFrames.Add(new Frame(540, 10, 0, 10, false, true));
        Effect3.EffectFrames.Add(new Frame(561, 37, 0, 37, false, true));
        Effect3.EffectFrames.Add(new Frame(600, 8, 0, 8, false, true));
        Effect3.EffectFrames.Add(new Frame(610, 10, 0, 10, false, true));
        Effect3.EffectFrames.Add(new Frame(620, 6, 14, 96, false, true));
        Effect3.EffectFrames.Add(new Frame(780, 36, 0, 36, false, true));
        Effect3.EffectFrames.Add(new Frame(820, 10, 0, 10, false, true));
        #endregion

        #region E:\RXCQ\bmp\magic\magic5
        Effect4.EffectFrames.Add(new Frame(0, 8, 0, 8, false, true));
        Effect4.EffectFrames.Add(new Frame(10, 10, 0, 80, false, true));
        Effect4.EffectFrames.Add(new Frame(90, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(100, 5, 0, 5, false, true));
        Effect4.EffectFrames.Add(new Frame(110, 3, 7, 24, false, true));
        Effect4.EffectFrames.Add(new Frame(270, 5, 0, 5, false, true));
        Effect4.EffectFrames.Add(new Frame(280, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(290, 6, 14, 96, false, true));
        Effect4.EffectFrames.Add(new Frame(450, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(470, 6, 4, 48, false, true));
        Effect4.EffectFrames.Add(new Frame(555, 5, 5, 40, false, true));
        Effect4.EffectFrames.Add(new Frame(630, 6, 4, 48, false, true));
        Effect4.EffectFrames.Add(new Frame(715, 5, 5, 40, false, true));
        Effect4.EffectFrames.Add(new Frame(790, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(820, 6, 4, 48, false, true));
        Effect4.EffectFrames.Add(new Frame(910, 6, 4, 48, false, true));
        Effect4.EffectFrames.Add(new Frame(975, 9, 1, 72, false, true));
        Effect4.EffectFrames.Add(new Frame(1065, 7, 0, 7, false, true));
        Effect4.EffectFrames.Add(new Frame(1075, 20, 0, 20, false, true));
        Effect4.EffectFrames.Add(new Frame(1095, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(1115, 7, 0, 7, false, true));
        Effect4.EffectFrames.Add(new Frame(1125, 20, 0, 20, false, true));
        Effect4.EffectFrames.Add(new Frame(1155, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(1175, 15, 0, 15, false, true));
        Effect4.EffectFrames.Add(new Frame(1205, 16, 0, 16, false, true));
        Effect4.EffectFrames.Add(new Frame(1235, 16, 0, 16, false, true));
        Effect4.EffectFrames.Add(new Frame(1265, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(1275, 6, 14, 96, false, true));
        Effect4.EffectFrames.Add(new Frame(1435, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(1455, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(1465, 6, 14, 96, false, true));
        Effect4.EffectFrames.Add(new Frame(1545, 6, 4, 48, false, true));
        Effect4.EffectFrames.Add(new Frame(1625, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(1645, 30, 0, 30, false, true));
        Effect4.EffectFrames.Add(new Frame(1685, 16, 0, 16, false, true));
        Effect4.EffectFrames.Add(new Frame(1715, 8, 0, 8, false, true));
        Effect4.EffectFrames.Add(new Frame(1725, 8, 0, 8, false, true));
        Effect4.EffectFrames.Add(new Frame(1735, 8, 0, 8, false, true));
        Effect4.EffectFrames.Add(new Frame(1755, 6, 0, 6, false, true));
        Effect4.EffectFrames.Add(new Frame(1765, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(1785, 15, 0, 15, false, true));
        Effect4.EffectFrames.Add(new Frame(1805, 6, 0, 6, false, true));
        Effect4.EffectFrames.Add(new Frame(1825, 13, 0, 13, false, true));
        Effect4.EffectFrames.Add(new Frame(1845, 3, 0, 3, false, true));
        Effect4.EffectFrames.Add(new Frame(1865, 20, 0, 20, false, true));
        Effect4.EffectFrames.Add(new Frame(1885, 30, 0, 30, false, true));
        Effect4.EffectFrames.Add(new Frame(1925, 10, 0, 10, false, true));
        Effect4.EffectFrames.Add(new Frame(1945, 20, 0, 20, false, true));
        #endregion

        #region E:\RXCQ\bmp\magic\magic6
        Effect5.EffectFrames.Add(new Frame(0, 6, 4, 48, false, true));
        Effect5.EffectFrames.Add(new Frame(80, 6, 0, 6, false, true));
        Effect5.EffectFrames.Add(new Frame(100, 15, 0, 15, false, true));
        Effect5.EffectFrames.Add(new Frame(120, 6, 0, 6, false, true));
        Effect5.EffectFrames.Add(new Frame(140, 8, 12, 128, false, true));
        Effect5.EffectFrames.Add(new Frame(300, 9, 0, 9, false, true));
        Effect5.EffectFrames.Add(new Frame(310, 8, 12, 128, false, true));
        Effect5.EffectFrames.Add(new Frame(470, 5, 0, 5, false, true));
        Effect5.EffectFrames.Add(new Frame(480, 6, 0, 6, false, true));
        Effect5.EffectFrames.Add(new Frame(490, 5, 0, 5, false, true));
        Effect5.EffectFrames.Add(new Frame(495, 3, 0, 3, false, true));
        Effect5.EffectFrames.Add(new Frame(510, 9, 1, 72, false, true));
        Effect5.EffectFrames.Add(new Frame(630, 20, 0, 20, false, true));
        Effect5.EffectFrames.Add(new Frame(650, 30, 0, 30, false, true));
        Effect5.EffectFrames.Add(new Frame(690, 10, 0, 10, false, true));
        Effect5.EffectFrames.Add(new Frame(710, 9, 0, 9, false, true));
        Effect5.EffectFrames.Add(new Frame(720, 6, 0, 6, false, true));
        Effect5.EffectFrames.Add(new Frame(730, 2, 0, 2, false, true));
        Effect5.EffectFrames.Add(new Frame(750, 8, 0, 8, false, true));
        #endregion

        #region E:\RXCQ\bmp\magic\magic7
        Effect6.EffectFrames.Add(new Frame(0, 4, 0, 4, false, true));
        Effect6.EffectFrames.Add(new Frame(20, 5, 0, 5, false, true));
        Effect6.EffectFrames.Add(new Frame(50, 10, 0, 10, false, true));
        Effect6.EffectFrames.Add(new Frame(70, 8, 0, 8, false, true));
        Effect6.EffectFrames.Add(new Frame(90, 10, 0, 10, false, true));
        Effect6.EffectFrames.Add(new Frame(110, 8, 0, 8, false, true));
        Effect6.EffectFrames.Add(new Frame(140, 6, 4, 48, false, true));
        Effect6.EffectFrames.Add(new Frame(240, 10, 0, 10, false, true));
        Effect6.EffectFrames.Add(new Frame(260, 28, 0, 28, false, true));
        Effect6.EffectFrames.Add(new Frame(310, 6, 4, 48, false, true));
        Effect6.EffectFrames.Add(new Frame(500, 14, 0, 14, false, true));
        Effect6.EffectFrames.Add(new Frame(690, 10, 0, 80, false, true));
        Effect6.EffectFrames.Add(new Frame(780, 9, 0, 9, false, true));
        Effect6.EffectFrames.Add(new Frame(810, 15, 0, 15, false, true));
        Effect6.EffectFrames.Add(new Frame(840, 8, 0, 8, false, true));
        Effect6.EffectFrames.Add(new Frame(860, 20, 0, 20, false, true));
        Effect6.EffectFrames.Add(new Frame(890, 26, 0, 26, false, true));
        Effect6.EffectFrames.Add(new Frame(920, 26, 0, 26, false, true));
        Effect6.EffectFrames.Add(new Frame(950, 26, 0, 26, false, true));
        Effect6.EffectFrames.Add(new Frame(980, 26, 0, 26, false, true));
        Effect6.EffectFrames.Add(new Frame(1010, 26, 0, 26, false, true));
        Effect6.EffectFrames.Add(new Frame(1040, 26, 0, 26, false, true));
        #endregion

        #region E:\RXCQ\bmp\magic\magic7-16
        Effect7.EffectFrames.Add(new Frame(0, 7, 3, 56, false, true));
        Effect7.EffectFrames.Add(new Frame(60, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(70, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(80, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(90, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(100, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(110, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(120, 4, 6, 24, false, true));
        Effect7.EffectFrames.Add(new Frame(180, 4, 6, 12, false, true));
        Effect7.EffectFrames.Add(new Frame(210, 5, 0, 5, false, true));
        Effect7.EffectFrames.Add(new Frame(230, 5, 0, 5, false, true));
        Effect7.EffectFrames.Add(new Frame(250, 7, 0, 7, false, true));
        Effect7.EffectFrames.Add(new Frame(260, 8, 2, 72, false, true));
        Effect7.EffectFrames.Add(new Frame(350, 11, 0, 11, false, true));
        Effect7.EffectFrames.Add(new Frame(380, 11, 0, 11, false, true));
        Effect7.EffectFrames.Add(new Frame(410, 14, 0, 14, false, true));
        Effect7.EffectFrames.Add(new Frame(440, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(460, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(480, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(500, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(520, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(540, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(560, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(580, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(600, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(620, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(630, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(640, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(650, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(670, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(690, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(710, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(730, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(750, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(770, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(790, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(810, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(830, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(840, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(850, 8, 0, 8, false, true));
        Effect7.EffectFrames.Add(new Frame(860, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(880, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(900, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(920, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(940, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(960, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(980, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(1000, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(1020, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(1040, 15, 0, 15, false, true));
        Effect7.EffectFrames.Add(new Frame(1060, 15, 0, 15, false, true));
        Effect7.EffectFrames.Add(new Frame(1080, 15, 0, 15, false, true));
        Effect7.EffectFrames.Add(new Frame(1100, 8, 12, 128, false, true));
        Effect7.EffectFrames.Add(new Frame(1270, 8, 12, 128, false, true));
        Effect7.EffectFrames.Add(new Frame(1440, 8, 12, 128, false, true));
        Effect7.EffectFrames.Add(new Frame(1600, 6, 4, 64, false, true));
        Effect7.EffectFrames.Add(new Frame(1690, 6, 4, 64, false, true));
        Effect7.EffectFrames.Add(new Frame(1780, 6, 4, 64, false, true));
        Effect7.EffectFrames.Add(new Frame(1870, 6, 4, 64, false, true));
        Effect7.EffectFrames.Add(new Frame(1960, 6, 4, 64, false, true));
        Effect7.EffectFrames.Add(new Frame(2050, 6, 4, 64, false, true));
        Effect7.EffectFrames.Add(new Frame(2140, 6, 4, 64, false, true));
        Effect7.EffectFrames.Add(new Frame(2230, 6, 4, 64, false, true));
        Effect7.EffectFrames.Add(new Frame(2320, 6, 4, 64, false, true));
        Effect7.EffectFrames.Add(new Frame(2410, 20, 0, 20, false, true));
        Effect7.EffectFrames.Add(new Frame(2430, 20, 0, 20, false, true));
        Effect7.EffectFrames.Add(new Frame(2450, 20, 0, 20, false, true));
        Effect7.EffectFrames.Add(new Frame(2470, 20, 0, 20, false, true));
        Effect7.EffectFrames.Add(new Frame(2490, 20, 0, 20, false, true));
        Effect7.EffectFrames.Add(new Frame(2520, 20, 0, 20, false, true));
        Effect7.EffectFrames.Add(new Frame(2550, 20, 0, 20, false, true));
        Effect7.EffectFrames.Add(new Frame(2570, 9, 0, 9, false, true));
        Effect7.EffectFrames.Add(new Frame(2580, 6, 0, 6, false, true));
        Effect7.EffectFrames.Add(new Frame(2590, 10, 0, 10, false, true));
        Effect7.EffectFrames.Add(new Frame(2600, 10, 0, 20, false, true));
        Effect7.EffectFrames.Add(new Frame(2620, 9, 0, 9, false, true));
        #endregion

        #region E:\RXCQ\bmp\magic\magic8
        Effect8.EffectFrames.Add(new Frame(0, 8, 2, 56, false, true));
        Effect8.EffectFrames.Add(new Frame(70, 10, 0, 10, false, true));
        Effect8.EffectFrames.Add(new Frame(80, 10, 0, 10, false, true));
        Effect8.EffectFrames.Add(new Frame(90, 17, 0, 17, false, true));
        Effect8.EffectFrames.Add(new Frame(110, 17, 0, 17, false, true));
        Effect8.EffectFrames.Add(new Frame(130, 17, 0, 17, false, true));
        Effect8.EffectFrames.Add(new Frame(160, 12, 0, 12, false, true));
        Effect8.EffectFrames.Add(new Frame(180, 15, 0, 15, false, true));
        Effect8.EffectFrames.Add(new Frame(200, 17, 0, 17, false, true));
        Effect8.EffectFrames.Add(new Frame(220, 9, 0, 9, false, true));
        Effect8.EffectFrames.Add(new Frame(230, 20, 0, 20, false, true));
        Effect8.EffectFrames.Add(new Frame(250, 6, 4, 48, false, true));
        Effect8.EffectFrames.Add(new Frame(330, 6, 4, 48, false, true));
        Effect8.EffectFrames.Add(new Frame(410, 6, 4, 48, false, true));
        Effect8.EffectFrames.Add(new Frame(500, 7, 0, 7, false, true));
        Effect8.EffectFrames.Add(new Frame(510, 7, 0, 7, false, true));
        Effect8.EffectFrames.Add(new Frame(520, 7, 0, 7, false, true));
        Effect8.EffectFrames.Add(new Frame(530, 9, 0, 9, false, true));
        Effect8.EffectFrames.Add(new Frame(540, 9, 0, 9, false, true));
        Effect8.EffectFrames.Add(new Frame(550, 9, 0, 9, false, true));
        Effect8.EffectFrames.Add(new Frame(560, 9, 0, 9, false, true));
        Effect8.EffectFrames.Add(new Frame(570, 9, 0, 9, false, true));
        Effect8.EffectFrames.Add(new Frame(600, 6, 14, 96, false, true));
        Effect8.EffectFrames.Add(new Frame(770, 6, 14, 96, false, true));
        Effect8.EffectFrames.Add(new Frame(940, 6, 14, 96, false, true));
        Effect8.EffectFrames.Add(new Frame(1110, 6, 14, 96, false, true));
        Effect8.EffectFrames.Add(new Frame(1280, 6, 14, 96, false, true));
        Effect8.EffectFrames.Add(new Frame(1450, 6, 14, 96, false, true));
        Effect8.EffectFrames.Add(new Frame(1620, 6, 4, 6, false, true));
        Effect8.EffectFrames.Add(new Frame(1630, 6, 4, 6, false, true));
        Effect8.EffectFrames.Add(new Frame(1640, 6, 4, 6, false, true));
        Effect8.EffectFrames.Add(new Frame(1660, 6, 4, 48, false, true));
        Effect8.EffectFrames.Add(new Frame(1750, 6, 4, 48, false, true));
        Effect8.EffectFrames.Add(new Frame(1840, 8, 2, 64, false, true));
        Effect8.EffectFrames.Add(new Frame(1930, 8, 0, 8, false, true));
        Effect8.EffectFrames.Add(new Frame(1940, 8, 0, 8, false, true));
        Effect8.EffectFrames.Add(new Frame(1950, 8, 0, 8, false, true));
        Effect8.EffectFrames.Add(new Frame(1970, 9, 0, 9, false, true));
        Effect8.EffectFrames.Add(new Frame(1980, 9, 0, 9, false, true));
        Effect8.EffectFrames.Add(new Frame(1990, 9, 0, 9, false, true));
        Effect8.EffectFrames.Add(new Frame(2040, 9, 0, 9, false, true));
        Effect8.EffectFrames.Add(new Frame(2060, 6, 4, 48, false, true));
        Effect8.EffectFrames.Add(new Frame(2150, 10, 0, 10, false, true));
        Effect8.EffectFrames.Add(new Frame(2180, 10, 0, 10, false, true));
        Effect8.EffectFrames.Add(new Frame(2200, 13, 7, 104, false, true));
        Effect8.EffectFrames.Add(new Frame(2380, 6, 4, 48, false, true));
        Effect8.EffectFrames.Add(new Frame(2460, 7, 0, 7, false, true));
        Effect8.EffectFrames.Add(new Frame(2480, 22, 0, 22, false, true));
        Effect8.EffectFrames.Add(new Frame(2510, 13, 0, 13, false, true));
        Effect8.EffectFrames.Add(new Frame(2530, 19, 0, 19, false, true));
        Effect8.EffectFrames.Add(new Frame(2550, 8, 2, 64, false, true));
        Effect8.EffectFrames.Add(new Frame(2630, 8, 2, 64, false, true));
        Effect8.EffectFrames.Add(new Frame(2710, 19, 0, 19, false, true));
        Effect8.EffectFrames.Add(new Frame(2730, 14, 0, 14, false, true));
        Effect8.EffectFrames.Add(new Frame(2750, 11, 0, 11, false, true));
        Effect8.EffectFrames.Add(new Frame(2771, 11, 0, 11, false, false));
        Effect8.EffectFrames.Add(new Frame(2790, 11, 0, 11, false, true));
        Effect8.EffectFrames.Add(new Frame(2811, 11, 0, 11, false, false));
        #endregion

        #region E:\RXCQ\bmp\magic\magic8-16
        Effect9.EffectFrames.Add(new Frame(0, 8, 2, 56, false, true));
        Effect9.EffectFrames.Add(new Frame(70, 10, 0, 10, false, true));
        Effect9.EffectFrames.Add(new Frame(80, 10, 0, 10, false, true));
        Effect9.EffectFrames.Add(new Frame(90, 17, 0, 17, false, true));
        Effect9.EffectFrames.Add(new Frame(110, 17, 0, 17, false, true));
        Effect9.EffectFrames.Add(new Frame(130, 17, 0, 17, false, true));
        Effect9.EffectFrames.Add(new Frame(160, 12, 0, 12, false, true));
        Effect9.EffectFrames.Add(new Frame(180, 15, 0, 15, false, true));
        Effect9.EffectFrames.Add(new Frame(200, 17, 0, 17, false, true));
        Effect9.EffectFrames.Add(new Frame(220, 9, 0, 9, false, true));
        Effect9.EffectFrames.Add(new Frame(230, 20, 0, 20, false, true));
        Effect9.EffectFrames.Add(new Frame(250, 6, 4, 48, false, true));
        Effect9.EffectFrames.Add(new Frame(330, 6, 4, 48, false, true));
        Effect9.EffectFrames.Add(new Frame(410, 6, 4, 48, false, true));
        Effect9.EffectFrames.Add(new Frame(500, 7, 0, 7, false, true));
        Effect9.EffectFrames.Add(new Frame(510, 7, 0, 7, false, true));
        Effect9.EffectFrames.Add(new Frame(520, 7, 0, 7, false, true));
        Effect9.EffectFrames.Add(new Frame(530, 9, 0, 9, false, true));
        Effect9.EffectFrames.Add(new Frame(540, 9, 0, 9, false, true));
        Effect9.EffectFrames.Add(new Frame(550, 9, 0, 9, false, true));
        Effect9.EffectFrames.Add(new Frame(560, 9, 0, 9, false, true));
        Effect9.EffectFrames.Add(new Frame(570, 9, 0, 9, false, true));
        Effect9.EffectFrames.Add(new Frame(600, 6, 14, 96, false, true));
        Effect9.EffectFrames.Add(new Frame(770, 6, 14, 96, false, true));
        Effect9.EffectFrames.Add(new Frame(940, 6, 14, 96, false, true));
        Effect9.EffectFrames.Add(new Frame(1110, 6, 14, 96, false, true));
        Effect9.EffectFrames.Add(new Frame(1280, 6, 14, 96, false, true));
        Effect9.EffectFrames.Add(new Frame(1450, 6, 14, 96, false, true));
        Effect9.EffectFrames.Add(new Frame(1620, 6, 4, 6, false, true));
        Effect9.EffectFrames.Add(new Frame(1630, 6, 4, 6, false, true));
        Effect9.EffectFrames.Add(new Frame(1640, 6, 4, 6, false, true));
        Effect9.EffectFrames.Add(new Frame(1660, 6, 4, 48, false, true));
        Effect9.EffectFrames.Add(new Frame(1750, 6, 4, 48, false, true));
        Effect9.EffectFrames.Add(new Frame(1840, 8, 2, 64, false, true));
        Effect9.EffectFrames.Add(new Frame(1930, 8, 0, 8, false, true));
        Effect9.EffectFrames.Add(new Frame(1940, 8, 0, 8, false, true));
        Effect9.EffectFrames.Add(new Frame(1950, 8, 0, 8, false, true));
        Effect9.EffectFrames.Add(new Frame(1970, 9, 0, 9, false, true));
        Effect9.EffectFrames.Add(new Frame(1980, 9, 0, 9, false, true));
        Effect9.EffectFrames.Add(new Frame(1990, 9, 0, 9, false, true));
        #endregion

        #region E:\RXCQ\bmp\magic\magic9
        Effect10.EffectFrames.Add(new Frame(0, 6, 4, 48, false, true));
        Effect10.EffectFrames.Add(new Frame(90, 6, 4, 48, false, true));
        Effect10.EffectFrames.Add(new Frame(180, 8, 2, 64, false, true));
        Effect10.EffectFrames.Add(new Frame(280, 8, 0, 8, false, true));
        Effect10.EffectFrames.Add(new Frame(290, 8, 0, 8, false, true));
        Effect10.EffectFrames.Add(new Frame(300, 8, 0, 8, false, true));
        Effect10.EffectFrames.Add(new Frame(310, 8, 0, 8, false, true));
        Effect10.EffectFrames.Add(new Frame(320, 8, 0, 8, false, true));
        Effect10.EffectFrames.Add(new Frame(330, 8, 0, 8, false, true));
        Effect10.EffectFrames.Add(new Frame(340, 8, 0, 8, false, true));
        Effect10.EffectFrames.Add(new Frame(350, 8, 0, 8, false, true));
        Effect10.EffectFrames.Add(new Frame(360, 8, 0, 8, false, true));
        Effect10.EffectFrames.Add(new Frame(380, 9, 0, 9, false, true));
        Effect10.EffectFrames.Add(new Frame(390, 9, 0, 9, false, true));
        Effect10.EffectFrames.Add(new Frame(400, 9, 0, 9, false, true));
        Effect10.EffectFrames.Add(new Frame(430, 9, 0, 9, false, true));
        Effect10.EffectFrames.Add(new Frame(439, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(440, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(450, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(460, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(470, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(480, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(490, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(500, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(510, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(530, 30, 0, 30, false, true));
        Effect10.EffectFrames.Add(new Frame(560, 30, 0, 30, false, true));
        Effect10.EffectFrames.Add(new Frame(590, 30, 0, 30, false, true));
        Effect10.EffectFrames.Add(new Frame(630, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(650, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(670, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(690, 20, 0, 20, false, true));
        Effect10.EffectFrames.Add(new Frame(710, 14, 0, 14, false, true));
        Effect10.EffectFrames.Add(new Frame(730, 14, 0, 14, false, true));
        Effect10.EffectFrames.Add(new Frame(750, 14, 0, 14, false, true));
        Effect10.EffectFrames.Add(new Frame(780, 13, 0, 13, false, true));
        Effect10.EffectFrames.Add(new Frame(800, 13, 0, 13, false, true));
        Effect10.EffectFrames.Add(new Frame(820, 13, 0, 13, false, true));
        Effect10.EffectFrames.Add(new Frame(840, 20, 0, 20, false, true));
        Effect10.EffectFrames.Add(new Frame(860, 13, 0, 13, false, true));
        Effect10.EffectFrames.Add(new Frame(880, 13, 0, 13, false, true));
        Effect10.EffectFrames.Add(new Frame(900, 13, 0, 13, false, true));
        Effect10.EffectFrames.Add(new Frame(930, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(950, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(970, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(990, 20, 0, 20, false, true));
        Effect10.EffectFrames.Add(new Frame(1010, 13, 0, 13, false, true));
        Effect10.EffectFrames.Add(new Frame(1030, 13, 0, 13, false, true));
        Effect10.EffectFrames.Add(new Frame(1050, 13, 0, 13, false, true));
        Effect10.EffectFrames.Add(new Frame(1090, 20, 0, 20, false, true));
        Effect10.EffectFrames.Add(new Frame(1120, 20, 0, 20, false, true));
        Effect10.EffectFrames.Add(new Frame(1150, 20, 0, 20, false, true));
        Effect10.EffectFrames.Add(new Frame(1180, 4, 0, 32, false, true));
        Effect10.EffectFrames.Add(new Frame(1212, 4, 0, 4, false, true));
        Effect10.EffectFrames.Add(new Frame(1220, 29, 0, 29, false, true));
        Effect10.EffectFrames.Add(new Frame(1254, 10, 0, 10, false, true));
        Effect10.EffectFrames.Add(new Frame(1440, 6, 14, 96, false, true));
        Effect10.EffectFrames.Add(new Frame(1600, 5, 0, 5, false, true));
        Effect10.EffectFrames.Add(new Frame(1610, 15, 0, 15, false, true));
        Effect10.EffectFrames.Add(new Frame(1630, 9, 0, 72, false, true));
        #endregion

        #region E:\RXCQ\bmp\magic\magic10
        Effect11.EffectFrames.Add(new Frame(0, 19, 0, 19, false, true));
        Effect11.EffectFrames.Add(new Frame(30, 21, 0, 21, false, true));
        Effect11.EffectFrames.Add(new Frame(60, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(80, 17, 0, 17, false, true));
        Effect11.EffectFrames.Add(new Frame(110, 40, 0, 40, false, true));
        Effect11.EffectFrames.Add(new Frame(160, 26, 0, 26, false, true));
        Effect11.EffectFrames.Add(new Frame(200, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(220, 10, 0, 10, false, true));
        Effect11.EffectFrames.Add(new Frame(240, 14, 0, 14, false, true));
        Effect11.EffectFrames.Add(new Frame(260, 14, 0, 14, false, true));
        Effect11.EffectFrames.Add(new Frame(280, 14, 0, 14, false, true));
        Effect11.EffectFrames.Add(new Frame(310, 21, 0, 21, false, true));
        Effect11.EffectFrames.Add(new Frame(330, 17, 0, 17, false, true));
        Effect11.EffectFrames.Add(new Frame(360, 10, 0, 10, false, true));
        Effect11.EffectFrames.Add(new Frame(380, 30, 0, 30, false, true));
        Effect11.EffectFrames.Add(new Frame(420, 15, 5, 120, false, true));
        Effect11.EffectFrames.Add(new Frame(590, 16, 0, 16, false, true));
        Effect11.EffectFrames.Add(new Frame(620, 16, 4, 128, false, true));
        Effect11.EffectFrames.Add(new Frame(790, 12, 8, 96, false, true));
        Effect11.EffectFrames.Add(new Frame(960, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(970, 16, 0, 16, false, true));
        Effect11.EffectFrames.Add(new Frame(990, 24, 0, 24, false, true));
        Effect11.EffectFrames.Add(new Frame(1030, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(1040, 24, 0, 24, false, true));
        Effect11.EffectFrames.Add(new Frame(1080, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(1100, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(1120, 6, 0, 6, false, true));
        Effect11.EffectFrames.Add(new Frame(1130, 13, 0, 13, false, true));
        Effect11.EffectFrames.Add(new Frame(1150, 11, 0, 11, false, true));
        Effect11.EffectFrames.Add(new Frame(1170, 26, 0, 26, false, true));
        Effect11.EffectFrames.Add(new Frame(1210, 23, 0, 23, false, true));
        Effect11.EffectFrames.Add(new Frame(1240, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(1260, 29, 0, 29, false, true));
        Effect11.EffectFrames.Add(new Frame(1290, 3, 17, 48, false, true));
        Effect11.EffectFrames.Add(new Frame(1450, 23, 0, 23, false, true));
        Effect11.EffectFrames.Add(new Frame(1480, 18, 0, 18, false, true));
        Effect11.EffectFrames.Add(new Frame(1500, 29, 0, 29, false, true));
        Effect11.EffectFrames.Add(new Frame(1530, 6, 0, 6, false, true));
        Effect11.EffectFrames.Add(new Frame(1536, 3, 0, 12, false, true));
        Effect11.EffectFrames.Add(new Frame(1550, 9, 0, 9, false, true));
        Effect11.EffectFrames.Add(new Frame(1560, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(1568, 13, 0, 13, false, true));
        Effect11.EffectFrames.Add(new Frame(1590, 16, 0, 16, false, true));
        Effect11.EffectFrames.Add(new Frame(1608, 10, 0, 10, false, true));
        Effect11.EffectFrames.Add(new Frame(1620, 7, 0, 7, false, true));
        Effect11.EffectFrames.Add(new Frame(1630, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(1640, 13, 0, 13, false, true));
        Effect11.EffectFrames.Add(new Frame(1660, 7, 0, 7, false, true));
        Effect11.EffectFrames.Add(new Frame(1670, 9, 0, 9, false, true));
        Effect11.EffectFrames.Add(new Frame(1680, 13, 0, 13, false, true));
        Effect11.EffectFrames.Add(new Frame(1700, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(1710, 20, 0, 20, false, true));
        Effect11.EffectFrames.Add(new Frame(1730, 8, 2, 64, false, true));
        Effect11.EffectFrames.Add(new Frame(1810, 28, 0, 28, false, true));
        Effect11.EffectFrames.Add(new Frame(1840, 13, 0, 13, false, true));
        Effect11.EffectFrames.Add(new Frame(1850, 30, 0, 30, false, true));
        Effect11.EffectFrames.Add(new Frame(1890, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(1900, 10, 0, 10, false, true));
        Effect11.EffectFrames.Add(new Frame(1910, 10, 0, 01, false, true));
        Effect11.EffectFrames.Add(new Frame(1920, 10, 0, 10, false, true));
        Effect11.EffectFrames.Add(new Frame(1930, 10, 0, 10, false, true));
        Effect11.EffectFrames.Add(new Frame(1940, 21, 0, 21, false, true));
        Effect11.EffectFrames.Add(new Frame(1970, 4, 0, 4, false, true));
        Effect11.EffectFrames.Add(new Frame(1980, 6, 0, 48, false, true));
        Effect11.EffectFrames.Add(new Frame(2030, 10, 0, 10, false, true));
        Effect11.EffectFrames.Add(new Frame(2040, 4, 6, 32, false, true));
        Effect11.EffectFrames.Add(new Frame(2120, 10, 0, 10, false, true));
        Effect11.EffectFrames.Add(new Frame(2136, 10, 0, 10, false, true));
        Effect11.EffectFrames.Add(new Frame(2152, 10, 0, 10, false, true));
        Effect11.EffectFrames.Add(new Frame(2168, 10, 0, 10, false, true));
        Effect11.EffectFrames.Add(new Frame(2190, 10, 0, 80, false, true));
        Effect11.EffectFrames.Add(new Frame(2300, 16, 0, 16, false, true));
        Effect11.EffectFrames.Add(new Frame(2320, 3, 0, 3, false, true));
        Effect11.EffectFrames.Add(new Frame(2330, 19, 0, 19, false, true));
        Effect11.EffectFrames.Add(new Frame(2350, 12, 0, 12, false, true));
        Effect11.EffectFrames.Add(new Frame(2370, 12, 0, 12, false, true));
        Effect11.EffectFrames.Add(new Frame(2390, 12, 0, 12, false, true));
        Effect11.EffectFrames.Add(new Frame(2410, 12, 0, 12, false, true));
        Effect11.EffectFrames.Add(new Frame(2430, 12, 0, 12, false, true));
        Effect11.EffectFrames.Add(new Frame(2450, 12, 0, 12, false, true));
        Effect11.EffectFrames.Add(new Frame(2470, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(2490, 8, 0, 8, false, true));
        Effect11.EffectFrames.Add(new Frame(2500, 20, 0, 20, false, true));
        Effect11.EffectFrames.Add(new Frame(2520, 30, 0, 30, false, true));
        Effect11.EffectFrames.Add(new Frame(2550, 40, 0, 40, false, true));
        Effect11.EffectFrames.Add(new Frame(2590, 30, 0, 30, false, true));
        Effect11.EffectFrames.Add(new Frame(2620, 40, 0, 40, false, true));
        Effect11.EffectFrames.Add(new Frame(2660, 20, 0, 20, false, true));
        Effect11.EffectFrames.Add(new Frame(2680, 26, 0, 26, false, true));
        Effect11.EffectFrames.Add(new Frame(2706, 26, 0, 26, false, true));
        Effect11.EffectFrames.Add(new Frame(2732, 26, 0, 26, false, true));
        Effect11.EffectFrames.Add(new Frame(2758, 26, 0, 26, false, true));
        Effect11.EffectFrames.Add(new Frame(2784, 26, 0, 26, false, true));
        Effect11.EffectFrames.Add(new Frame(2810, 26, 0, 26, false, true));
        Effect11.EffectFrames.Add(new Frame(2836, 26, 0, 26, false, true));
        Effect11.EffectFrames.Add(new Frame(2862, 26, 0, 26, false, true));
        Effect11.EffectFrames.Add(new Frame(2888, 26, 0, 26, false, true));
        Effect11.EffectFrames.Add(new Frame(2920, 7, 0, 7, false, true));
        Effect11.EffectFrames.Add(new Frame(2950, 25, 0, 25, false, true));
        Effect11.EffectFrames.Add(new Frame(2980, 20, 0, 20, false, true));
        Effect11.EffectFrames.Add(new Frame(3000, 20, 0, 20, false, true));
        Effect11.EffectFrames.Add(new Frame(3020, 20, 0, 20, false, true));
        Effect11.EffectFrames.Add(new Frame(3040, 20, 0, 20, false, true));
        Effect11.EffectFrames.Add(new Frame(3060, 14, 0, 14, false, true));
        Effect11.EffectFrames.Add(new Frame(3080, 14, 0, 14, false, true));
        Effect11.EffectFrames.Add(new Frame(3100, 14, 0, 14, false, true));
        Effect11.EffectFrames.Add(new Frame(3120, 14, 0, 14, false, true));
        Effect11.EffectFrames.Add(new Frame(3140, 9, 1, 72, false, true));
        Effect11.EffectFrames.Add(new Frame(3220, 22, 0, 22, false, true));
        Effect11.EffectFrames.Add(new Frame(3250, 8, 2, 64, false, true));
        Effect11.EffectFrames.Add(new Frame(3330, 4, 0, 64, false, true));
        Effect11.EffectFrames.Add(new Frame(3396, 6, 0, 6, false, true));
        Effect11.EffectFrames.Add(new Frame(3405, 5, 0, 5, false, true));
        Effect11.EffectFrames.Add(new Frame(3410, 17, 0, 17, false, true));
        Effect11.EffectFrames.Add(new Frame(3430, 17, 0, 17, false, true));
        Effect11.EffectFrames.Add(new Frame(3450, 17, 0, 17, false, true));
        Effect11.EffectFrames.Add(new Frame(3470, 17, 0, 17, false, true));
        Effect11.EffectFrames.Add(new Frame(3490, 17, 0, 17, false, true));
        #endregion

        #endregion
    }
}

public class Frame
{
    public int Start, Count, Skip, MaxCount;
    public bool Alpha = false;
    public bool EffectAlpha = false;

    public int OffSet
    {
        get { return Count + Skip; }
    }

    public int FrameIndex
    {
        get { return Start + MaxCount; }
    }

    public Frame(int start, int count, int skip, int maxCount, bool alpha = false, bool effectAlpha = false)
    {
        Start = start;
        Count = count;
        Skip = skip;
        MaxCount = maxCount;
        Alpha = alpha;
        EffectAlpha = effectAlpha;
    }
}

