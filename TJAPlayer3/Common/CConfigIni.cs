﻿using FDK;
using FDK.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace TJAPlayer3
{
	internal class CConfigIni : INotifyPropertyChanged
	{
		private const int MinimumKeyboardSoundLevelIncrement = 1;
		private const int MaximumKeyboardSoundLevelIncrement = 20;
		private const int DefaultKeyboardSoundLevelIncrement = 5;

		// クラス

		#region [ CKeyAssign ]
		public class CKeyAssign
		{
			public class CKeyAssignPad
			{
				public CConfigIni.CKeyAssign.STKEYASSIGN[] HH
				{
					get
					{
						return this.padHH_R;
					}
					set
					{
						this.padHH_R = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] R
				{
					get
					{
						return this.padHH_R;
					}
					set
					{
						this.padHH_R = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] SD
				{
					get
					{
						return this.padSD_G;
					}
					set
					{
						this.padSD_G = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] G
				{
					get
					{
						return this.padSD_G;
					}
					set
					{
						this.padSD_G = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] BD
				{
					get
					{
						return this.padBD_B;
					}
					set
					{
						this.padBD_B = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] B
				{
					get
					{
						return this.padBD_B;
					}
					set
					{
						this.padBD_B = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] HT
				{
					get
					{
						return this.padHT_Pick;
					}
					set
					{
						this.padHT_Pick = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] Pick
				{
					get
					{
						return this.padHT_Pick;
					}
					set
					{
						this.padHT_Pick = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] LT
				{
					get
					{
						return this.padLT_Wail;
					}
					set
					{
						this.padLT_Wail = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] Wail
				{
					get
					{
						return this.padLT_Wail;
					}
					set
					{
						this.padLT_Wail = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] FT
				{
					get
					{
						return this.padFT_Cancel;
					}
					set
					{
						this.padFT_Cancel = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] Cancel
				{
					get
					{
						return this.padFT_Cancel;
					}
					set
					{
						this.padFT_Cancel = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] CY
				{
					get
					{
						return this.padCY_Decide;
					}
					set
					{
						this.padCY_Decide = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] Decide
				{
					get
					{
						return this.padCY_Decide;
					}
					set
					{
						this.padCY_Decide = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] HHO
				{
					get
					{
						return this.padHHO;
					}
					set
					{
						this.padHHO = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] RD
				{
					get
					{
						return this.padRD;
					}
					set
					{
						this.padRD = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] LC
				{
					get
					{
						return this.padLC;
					}
					set
					{
						this.padLC = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] LP
				{
					get
					{
						return this.padLP;
					}
					set
					{
						this.padLP = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] LBD
				{
					get
					{
						return this.padLBD;
					}
					set
					{
						this.padLBD = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] Capture
				{
					get
					{
						return this.padCapture;
					}
					set
					{
						this.padCapture = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftRed
				{
					get
					{
						return this.padLRed;
					}
					set
					{
						this.padLRed = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] RightRed
				{
					get
					{
						return this.padRRed;
					}
					set
					{
						this.padRRed = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftBlue
				{
					get
					{
						return this.padLBlue;
					}
					set
					{
						this.padLBlue = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] RightBlue
				{
					get
					{
						return this.padRBlue;
					}
					set
					{
						this.padRBlue = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftRed2P
				{
					get
					{
						return this.padLRed2P;
					}
					set
					{
						this.padLRed2P = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] RightRed2P
				{
					get
					{
						return this.padRRed2P;
					}
					set
					{
						this.padRRed2P = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftBlue2P
				{
					get
					{
						return this.padLBlue2P;
					}
					set
					{
						this.padLBlue2P = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] RightBlue2P
				{
					get
					{
						return this.padRBlue2P;
					}
					set
					{
						this.padRBlue2P = value;
					}
				}
				public CConfigIni.CKeyAssign.STKEYASSIGN[] this[int index]
				{
					get
					{
						switch (index)
						{
							case (int)EKeyConfigPad.HH:
								return this.padHH_R;

							case (int)EKeyConfigPad.SD:
								return this.padSD_G;

							case (int)EKeyConfigPad.BD:
								return this.padBD_B;

							case (int)EKeyConfigPad.HT:
								return this.padHT_Pick;

							case (int)EKeyConfigPad.LT:
								return this.padLT_Wail;

							case (int)EKeyConfigPad.FT:
								return this.padFT_Cancel;

							case (int)EKeyConfigPad.CY:
								return this.padCY_Decide;

							case (int)EKeyConfigPad.HHO:
								return this.padHHO;

							case (int)EKeyConfigPad.RD:
								return this.padRD;

							case (int)EKeyConfigPad.LC:
								return this.padLC;

							case (int)EKeyConfigPad.LP: // #27029 2012.1.4 from
								return this.padLP;          //

							case (int)EKeyConfigPad.LBD:    // #27029 2012.1.4 from
								return this.padLBD;         //

							case (int)EKeyConfigPad.LRed:
								return this.padLRed;

							case (int)EKeyConfigPad.RRed:
								return this.padRRed;

							case (int)EKeyConfigPad.LBlue:
								return this.padLBlue;

							case (int)EKeyConfigPad.RBlue:
								return this.padRBlue;

							case (int)EKeyConfigPad.LRed2P:
								return this.padLRed2P;

							case (int)EKeyConfigPad.RRed2P:
								return this.padRRed2P;

							case (int)EKeyConfigPad.LBlue2P:
								return this.padLBlue2P;

							case (int)EKeyConfigPad.RBlue2P:
								return this.padRBlue2P;

							case (int)EKeyConfigPad.Capture:
								return this.padCapture;
						}
						throw new IndexOutOfRangeException();
					}
					set
					{
						switch (index)
						{
							case (int)EKeyConfigPad.HH:
								this.padHH_R = value;
								return;

							case (int)EKeyConfigPad.SD:
								this.padSD_G = value;
								return;

							case (int)EKeyConfigPad.BD:
								this.padBD_B = value;
								return;

							case (int)EKeyConfigPad.Pick:
								this.padHT_Pick = value;
								return;

							case (int)EKeyConfigPad.LT:
								this.padLT_Wail = value;
								return;

							case (int)EKeyConfigPad.FT:
								this.padFT_Cancel = value;
								return;

							case (int)EKeyConfigPad.CY:
								this.padCY_Decide = value;
								return;

							case (int)EKeyConfigPad.HHO:
								this.padHHO = value;
								return;

							case (int)EKeyConfigPad.RD:
								this.padRD = value;
								return;

							case (int)EKeyConfigPad.LC:
								this.padLC = value;
								return;

							case (int)EKeyConfigPad.LP:
								this.padLP = value;
								return;

							case (int)EKeyConfigPad.LBD:
								this.padLBD = value;
								return;

							case (int)EKeyConfigPad.LRed:
								this.padLRed = value;
								return;

							case (int)EKeyConfigPad.RRed:
								this.padRRed = value;
								return;

							case (int)EKeyConfigPad.LBlue:
								this.padLBlue = value;
								return;

							case (int)EKeyConfigPad.RBlue:
								this.padRBlue = value;
								return;

							case (int)EKeyConfigPad.LRed2P:
								this.padLRed2P = value;
								return;

							case (int)EKeyConfigPad.RRed2P:
								this.padRRed2P = value;
								return;

							case (int)EKeyConfigPad.LBlue2P:
								this.padLBlue2P = value;
								return;

							case (int)EKeyConfigPad.RBlue2P:
								this.padRBlue2P = value;
								return;

							case (int)EKeyConfigPad.Capture:
								this.padCapture = value;
								return;
						}
						throw new IndexOutOfRangeException();
					}
				}

				#region [ private ]
				//-----------------
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padBD_B;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padCY_Decide;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padFT_Cancel;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padHH_R;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padHHO;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padHT_Pick;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padLC;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padLT_Wail;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padRD;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padSD_G;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padLP;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padLBD;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padLRed;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padLBlue;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padRRed;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padRBlue;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padLRed2P;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padLBlue2P;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padRRed2P;
				private CConfigIni.CKeyAssign.STKEYASSIGN[] padRBlue2P;

				private CConfigIni.CKeyAssign.STKEYASSIGN[] padCapture;
				//-----------------
				#endregion
			}

			[StructLayout(LayoutKind.Sequential)]
			public struct STKEYASSIGN
			{
				public E入力デバイス 入力デバイス;
				public int ID;
				public int コード;
				public STKEYASSIGN(E入力デバイス DeviceType, int nID, int nCode)
				{
					this.入力デバイス = DeviceType;
					this.ID = nID;
					this.コード = nCode;
				}
			}

			public CKeyAssignPad Bass = new CKeyAssignPad();
			public CKeyAssignPad Drums = new CKeyAssignPad();
			public CKeyAssignPad Guitar = new CKeyAssignPad();
			public CKeyAssignPad Taiko = new CKeyAssignPad();
			public CKeyAssignPad System = new CKeyAssignPad();
			public CKeyAssignPad this[int index]
			{
				get
				{
					switch (index)
					{
						case (int)EKeyConfigPart.DRUMS:
							return this.Drums;

						case (int)EKeyConfigPart.GUITAR:
							return this.Guitar;

						case (int)EKeyConfigPart.BASS:
							return this.Bass;

						case (int)EKeyConfigPart.TAIKO:
							return this.Taiko;

						case (int)EKeyConfigPart.SYSTEM:
							return this.System;
					}
					throw new IndexOutOfRangeException();
				}
				set
				{
					switch (index)
					{
						case (int)EKeyConfigPart.DRUMS:
							this.Drums = value;
							return;

						case (int)EKeyConfigPart.GUITAR:
							this.Guitar = value;
							return;

						case (int)EKeyConfigPart.BASS:
							this.Bass = value;
							return;

						case (int)EKeyConfigPart.TAIKO:
							this.Taiko = value;
							return;

						case (int)EKeyConfigPart.SYSTEM:
							this.System = value;
							return;
					}
					throw new IndexOutOfRangeException();
				}
			}
		}
		#endregion

		//
		public enum ESoundDeviceTypeForConfig
		{
			ACM = 0,
			// DirectSound,
			ASIO,
			WASAPI,
			Unknown = 99
		}
		// プロパティ

#if false      // #23625 2011.1.11 Config.iniからダメージ/回復値の定数変更を行う場合はここを有効にする 087リリースに合わせ機能無効化                                                                                   
		//----------------------------------------
		public float[,] fGaugeFactor = new float[5,2];
		public float[] fDamageLevelFactor = new float[3];
		//----------------------------------------
#endif
		public int nBGAlpha;
		public bool bAVI有効;
		public bool bBGA有効;
		public bool bBGM音を発声する;
		public STDGBVALUE<bool> bHidden;
		public STDGBVALUE<bool> bLeft;
		public STDGBVALUE<bool> bLight;
		public bool bLogDTX詳細ログ出力;
		public bool bLog曲検索ログ出力;
		public bool bLog作成解放ログ出力;
		public STDGBVALUE<bool> bReverse;
		//public STDGBVALUE<E判定表示優先度> e判定表示優先度;
		public E判定表示優先度 e判定表示優先度;
		public STDGBVALUE<E判定位置> e判定位置;         // #33891 2014.6.26 yyagi
		public bool bScoreIniを出力する;
		public bool bSTAGEFAILED有効;
		public STDGBVALUE<bool> bSudden;
		public bool bTight;
		public STDGBVALUE<bool> bGraph;     // #24074 2011.01.23 add ikanick
		public bool bWave再生位置自動調整機能有効;
		public bool bストイックモード;
		public bool bランダムセレクトで子BOXを検索対象とする;
		public bool bログ出力;
		public bool b演奏情報を表示する;
		public bool b垂直帰線待ちを行う;
		public bool b全画面モード;
		public int n初期ウィンドウ開始位置X; // #30675 2013.02.04 ikanick add
		public int n初期ウィンドウ開始位置Y;
		public int nウインドウwidth;             // #23510 2010.10.31 yyagi add
		public int nウインドウheight;                // #23510 2010.10.31 yyagi add
		public Dictionary<int, string> dicJoystick;
		public Eダークモード eDark;
		public STDGBVALUE<Eランダムモード> eRandom;
		public Eダメージレベル eダメージレベル;
		public CKeyAssign KeyAssign;
		public int n非フォーカス時スリープms;       // #23568 2010.11.04 ikanick add
		public int nフレーム毎スリープms;            // #xxxxx 2011.11.27 yyagi add
		public int n演奏速度;
		public int n曲が選択されてからプレビュー音が鳴るまでのウェイトms;
		public int n曲が選択されてからプレビュー画像が表示開始されるまでのウェイトms;

		private bool _applyLoudnessMetadata;

		public bool ApplyLoudnessMetadata
		{
			get => _applyLoudnessMetadata;
			set => SetProperty(ref _applyLoudnessMetadata, value, nameof(ApplyLoudnessMetadata));
		}

		private double _targetLoudness;

		public double TargetLoudness
		{
			get => _targetLoudness;
			set => SetProperty(ref _targetLoudness, value, nameof(TargetLoudness));
		}

		private bool _applySongVol;

		public bool ApplySongVol
		{
			get => _applySongVol;
			set => SetProperty(ref _applySongVol, value, nameof(ApplySongVol));
		}

		private int _soundEffectLevel;

		public int SoundEffectLevel
		{
			get => _soundEffectLevel;
			set => SetProperty(ref _soundEffectLevel, value, nameof(SoundEffectLevel));
		}

		private int _voiceLevel;

		public int VoiceLevel
		{
			get => _voiceLevel;
			set => SetProperty(ref _voiceLevel, value, nameof(VoiceLevel));
		}

		private int _songPreviewLevel;

		public int SongPreviewLevel
		{
			get => _songPreviewLevel;
			set => SetProperty(ref _songPreviewLevel, value, nameof(SongPreviewLevel));
		}

		private int _songPlaybackLevel;

		public int SongPlaybackLevel
		{
			get => _songPlaybackLevel;
			set => SetProperty(ref _songPlaybackLevel, value, nameof(SongPlaybackLevel));
		}

		private int _keyboardSoundLevelIncrement;

		public int KeyboardSoundLevelIncrement
		{
			get => _keyboardSoundLevelIncrement;
			set => SetProperty(
				ref _keyboardSoundLevelIncrement,
				value.Clamp(MinimumKeyboardSoundLevelIncrement, MaximumKeyboardSoundLevelIncrement),
				nameof(KeyboardSoundLevelIncrement));
		}

		public STDGBVALUE<int> n表示可能な最小コンボ数;
		public STDGBVALUE<int> n譜面スクロール速度;
		public string strDTXManiaのバージョン;
		public string str曲データ検索パス;
		public string FontName;
		public bool bBranchGuide;
		public int nScoreMode;
		public int nDefaultCourse; //2017.01.30 DD デフォルトでカーソルをあわせる難易度


		public int nPlayerCount; //2017.08.18 kairera0467 マルチプレイ対応
		public bool b太鼓パートAutoPlay;
		public bool b太鼓パートAutoPlay2P; //2017.08.16 kairera0467 マルチプレイ対応
		public bool bAuto先生の連打;
		public bool bAuto連打色変更;
		public bool bAutoBalloon;
		public bool b大音符判定;
		public int n両手判定の待ち時間;
		public int nBranchAnime;

		public bool bJudgeCountDisplay;

		// 各画像の表示・非表示設定
		public bool ShowChara;
		public bool ShowDancer;
		public bool ShowRunner;
		public bool ShowFooter;
		public bool ShowMob;
		public bool ShowPuchiChara; // リザーブ
		public bool ShowBPM;
		//

		public EScrollMode eScrollMode = EScrollMode.Normal;
		public bool bスクロールモードを上書き = false;

		public bool bHispeedRandom;
		public Eステルスモード eSTEALTH;
		public bool bNoInfo;

		public int nDefaultSongSort;

		public EGame eGameMode;
		public bool bSuperHard = false;
		public bool bJust;

		public bool bEndingAnime = false;   // 2017.01.27 DD 「また遊んでね」画面の有効/無効オプション追加


		public STDGBVALUE<E判定文字表示位置> 判定文字表示位置;
		//		public int nハイハット切り捨て下限Velocity;
		//		public int n切り捨て下限Velocity;			// #23857 2010.12.12 yyagi VelocityMin
		public int nInputAdjustTimeMs;
		public STDGBVALUE<int> nJudgeLinePosOffset; // #31602 2013.6.23 yyagi 判定ライン表示位置のオフセット
		public bool bIsAutoResultCapture;           // #25399 2011.6.9 yyagi リザルト画像自動保存機能のON/OFF制御
		public int nPoliphonicSounds;               // #28228 2012.5.1 yyagi レーン毎の最大同時発音数
		public bool bバッファ入力を行う;
		public bool bIsEnabledSystemMenu;           // #28200 2012.5.1 yyagi System Menuの使用可否切替
		public string strSystemSkinSubfolderFullName;   // #28195 2012.5.2 yyagi Skin切替用 System/以下のサブフォルダ名
		public bool bConfigIniがないかDTXManiaのバージョンが異なる
		{
			get
			{
				return (!this.bConfigIniが存在している || !TJAPlayer3.VERSION.Equals(this.strDTXManiaのバージョン));
			}
		}
		public bool bEnterがキー割り当てのどこにも使用されていない
		{
			get
			{
				for (int i = 0; i <= (int)EKeyConfigPart.SYSTEM; i++)
				{
					for (int j = 0; j <= (int)EKeyConfigPad.Capture; j++)
					{
						for (int k = 0; k < 0x10; k++)
						{
							if ((this.KeyAssign[i][j][k].入力デバイス == E入力デバイス.キーボード) && (this.KeyAssign[i][j][k].コード == (int)SlimDX.DirectInput.Key.Return))
							{
								return false;
							}
						}
					}
				}
				return true;
			}
		}
		public bool bウィンドウモード
		{
			get
			{
				return !this.b全画面モード;
			}
			set
			{
				this.b全画面モード = !value;
			}
		}
		public bool b演奏情報を表示しない
		{
			get
			{
				return !this.b演奏情報を表示する;
			}
			set
			{
				this.b演奏情報を表示する = !value;
			}
		}
		public int n背景の透過度
		{
			get
			{
				return this.nBGAlpha;
			}
			set
			{
				if (value < 0)
				{
					this.nBGAlpha = 0;
				}
				else if (value > 0xff)
				{
					this.nBGAlpha = 0xff;
				}
				else
				{
					this.nBGAlpha = value;
				}
			}
		}
		public int nRisky;                      // #23559 2011.6.20 yyagi Riskyでの残ミス数。0で閉店
		public bool bIsAllowedDoubleClickFullscreen;    // #26752 2011.11.27 yyagi ダブルクリックしてもフルスクリーンに移行しない
		public STAUTOPLAY bAutoPlay;
		public int nSoundDeviceType;                // #24820 2012.12.23 yyagi 出力サウンドデバイス(0=ACM(にしたいが設計がきつそうならDirectShow), 1=ASIO, 2=WASAPI)
		public int nWASAPIBufferSizeMs;             // #24820 2013.1.15 yyagi WASAPIのバッファサイズ
													//		public int nASIOBufferSizeMs;				// #24820 2012.12.28 yyagi ASIOのバッファサイズ
		public int nASIODevice;                     // #24820 2013.1.17 yyagi ASIOデバイス
		public bool bUseOSTimer;                    // #33689 2014.6.6 yyagi 演奏タイマーの種類
		public bool bDynamicBassMixerManagement;    // #24820
		public bool bTimeStretch;                   // #23664 2013.2.24 yyagi ピッチ変更無しで再生速度を変更するかどうか
		public STDGBVALUE<EInvisible> eInvisible;   // #32072 2013.9.20 yyagi チップを非表示にする
		public int nDisplayTimesMs, nFadeoutTimeMs;

		public STDGBVALUE<int> nViewerScrollSpeed;
		public bool bViewerVSyncWait;
		public bool bViewerShowDebugStatus;
		public bool bViewerTimeStretch;
		public bool bViewerDrums有効, bViewerGuitar有効;
		//public bool bNoMP3Streaming;				// 2014.4.14 yyagi; mp3のシーク位置がおかしくなる場合は、これをtrueにすることで、wavにデコードしてからオンメモリ再生する
		public int nMasterVolume;
		public bool ShinuchiMode; // 真打モード
		public bool FastRender; // 事前画像描画モード
		public int MusicPreTimeMs; // 音源再生前の待機時間ms
		/// <summary>
		/// DiscordのRitch Presenceに再生中の.tjaファイルの情報を送信するかどうか。
		/// </summary>
		public bool SendDiscordPlayingInformation;
#if false
		[StructLayout( LayoutKind.Sequential )]
		public struct STAUTOPLAY								// C定数のEレーンとindexを一致させること
		{
			public bool LC;			// 0
			public bool HH;			// 1
			public bool SD;			// 2
			public bool BD;			// 3
			public bool HT;			// 4
			public bool LT;			// 5
			public bool FT;			// 6
			public bool CY;			// 7
			public bool RD;			// 8
			public bool Guitar;		// 9	(not used)
			public bool Bass;		// 10	(not used)
			public bool GtR;		// 11
			public bool GtG;		// 12
			public bool GtB;		// 13
			public bool GtPick;		// 14
			public bool GtW;		// 15
			public bool BsR;		// 16
			public bool BsG;		// 17
			public bool BsB;		// 18
			public bool BsPick;		// 19
			public bool BsW;		// 20
			public bool this[ int index ]
			{
				get
				{
					switch ( index )
					{
						case (int) Eレーン.LC:
							return this.LC;
						case (int) Eレーン.HH:
							return this.HH;
						case (int) Eレーン.SD:
							return this.SD;
						case (int) Eレーン.BD:
							return this.BD;
						case (int) Eレーン.HT:
							return this.HT;
						case (int) Eレーン.LT:
							return this.LT;
						case (int) Eレーン.FT:
							return this.FT;
						case (int) Eレーン.CY:
							return this.CY;
						case (int) Eレーン.RD:
							return this.RD;
						case (int) Eレーン.Guitar:
							return this.Guitar;
						case (int) Eレーン.Bass:
							return this.Bass;
						case (int) Eレーン.GtR:
							return this.GtR;
						case (int) Eレーン.GtG:
							return this.GtG;
						case (int) Eレーン.GtB:
							return this.GtB;
						case (int) Eレーン.GtPick:
							return this.GtPick;
						case (int) Eレーン.GtW:
							return this.GtW;
						case (int) Eレーン.BsR:
							return this.BsR;
						case (int) Eレーン.BsG:
							return this.BsG;
						case (int) Eレーン.BsB:
							return this.BsB;
						case (int) Eレーン.BsPick:
							return this.BsPick;
						case (int) Eレーン.BsW:
							return this.BsW;
					}
					throw new IndexOutOfRangeException();
				}
				set
				{
					switch ( index )
					{
						case (int) Eレーン.LC:
							this.LC = value;
							return;
						case (int) Eレーン.HH:
							this.HH = value;
							return;
						case (int) Eレーン.SD:
							this.SD = value;
							return;
						case (int) Eレーン.BD:
							this.BD = value;
							return;
						case (int) Eレーン.HT:
							this.HT = value;
							return;
						case (int) Eレーン.LT:
							this.LT = value;
							return;
						case (int) Eレーン.FT:
							this.FT = value;
							return;
						case (int) Eレーン.CY:
							this.CY = value;
							return;
						case (int) Eレーン.RD:
							this.RD = value;
							return;
						case (int) Eレーン.Guitar:
							this.Guitar = value;
							return;
						case (int) Eレーン.Bass:
							this.Bass = value;
							return;
						case (int) Eレーン.GtR:
							this.GtR = value;
							return;
						case (int) Eレーン.GtG:
							this.GtG = value;
							return;
						case (int) Eレーン.GtB:
							this.GtB = value;
							return;
						case (int) Eレーン.GtPick:
							this.GtPick = value;
							return;
						case (int) Eレーン.GtW:
							this.GtW = value;
							return;
						case (int) Eレーン.BsR:
							this.BsR = value;
							return;
						case (int) Eレーン.BsG:
							this.BsG = value;
							return;
						case (int) Eレーン.BsB:
							this.BsB = value;
							return;
						case (int) Eレーン.BsPick:
							this.BsPick = value;
							return;
						case (int) Eレーン.BsW:
							this.BsW = value;
							return;
					}
					throw new IndexOutOfRangeException();
				}
			}
		}
#endif
		#region [ STRANGE ]
		public STRANGE nヒット範囲ms;
		[StructLayout(LayoutKind.Sequential)]
		public struct STRANGE
		{
			public int Perfect;
			public int Great;
			public int Good;
			public int Poor;
			public int this[int index]
			{
				get
				{
					switch (index)
					{
						case 0:
							return this.Perfect;

						case 1:
							return this.Great;

						case 2:
							return this.Good;

						case 3:
							return this.Poor;
					}
					throw new IndexOutOfRangeException();
				}
				set
				{
					switch (index)
					{
						case 0:
							this.Perfect = value;
							return;

						case 1:
							this.Great = value;
							return;

						case 2:
							this.Good = value;
							return;

						case 3:
							this.Poor = value;
							return;
					}
					throw new IndexOutOfRangeException();
				}
			}
		}
		#endregion
		#region [ STLANEVALUE ]
		public STLANEVALUE nVelocityMin;
		[StructLayout(LayoutKind.Sequential)]
		public struct STLANEVALUE
		{
			public int LC;
			public int HH;
			public int SD;
			public int BD;
			public int HT;
			public int LT;
			public int FT;
			public int CY;
			public int RD;
			public int LP;
			public int LBD;
			public int Guitar;
			public int Bass;
			public int this[int index]
			{
				get
				{
					switch (index)
					{
						case 0:
							return this.LC;

						case 1:
							return this.HH;

						case 2:
							return this.SD;

						case 3:
							return this.BD;

						case 4:
							return this.HT;

						case 5:
							return this.LT;

						case 6:
							return this.FT;

						case 7:
							return this.CY;

						case 8:
							return this.RD;

						case 9:
							return this.LP;

						case 10:
							return this.LBD;

						case 11:
							return this.Guitar;

						case 12:
							return this.Bass;
					}
					throw new IndexOutOfRangeException();
				}
				set
				{
					switch (index)
					{
						case 0:
							this.LC = value;
							return;

						case 1:
							this.HH = value;
							return;

						case 2:
							this.SD = value;
							return;

						case 3:
							this.BD = value;
							return;

						case 4:
							this.HT = value;
							return;

						case 5:
							this.LT = value;
							return;

						case 6:
							this.FT = value;
							return;

						case 7:
							this.CY = value;
							return;

						case 8:
							this.RD = value;
							return;

						case 9:
							this.LP = value;
							return;

						case 10:
							this.LBD = value;
							return;

						case 11:
							this.Guitar = value;
							return;

						case 12:
							this.Bass = value;
							return;
					}
					throw new IndexOutOfRangeException();
				}
			}
		}
		#endregion


		#region[Ver.K追加オプション]
		//--------------------------
		//ゲーム内のオプションに加えて、
		//システム周りのオプションもこのブロックで記述している。
		#region[Display]
		//--------------------------
		public EClipDispType eClipDispType;
		#endregion

		#region[Position]
		public Eレーンタイプ eLaneType;
		public Eミラー eMirror;

		#endregion
		#region[System]
		public bool bDirectShowMode;
		#endregion

		//--------------------------
		#endregion


		// コンストラクタ

		public CConfigIni()
		{
#if false      // #23625 2011.1.11 Config.iniからダメージ/回復値の定数変更を行う場合はここを有効にする 087リリースに合わせ機能無効化                                                                                   
			//----------------------------------------
			this.fGaugeFactor[0,0] =  0.004f;
			this.fGaugeFactor[0,1] =  0.006f;
			this.fGaugeFactor[1,0] =  0.002f;
			this.fGaugeFactor[1,1] =  0.003f;
			this.fGaugeFactor[2,0] =  0.000f;
			this.fGaugeFactor[2,1] =  0.000f;
			this.fGaugeFactor[3,0] = -0.020f;
			this.fGaugeFactor[3,1] = -0.030f;
			this.fGaugeFactor[4,0] = -0.050f;
			this.fGaugeFactor[4,1] = -0.050f;

			this.fDamageLevelFactor[0] = 0.5f;
			this.fDamageLevelFactor[1] = 1.0f;
			this.fDamageLevelFactor[2] = 1.5f;
			//----------------------------------------
#endif
			this.strDTXManiaのバージョン = "Unknown";
			this.str曲データ検索パス = @".\";
			this.b全画面モード = false;
			this.b垂直帰線待ちを行う = true;
			this.n初期ウィンドウ開始位置X = 0; // #30675 2013.02.04 ikanick add
			this.n初期ウィンドウ開始位置Y = 0;
			this.nウインドウwidth = SampleFramework.GameWindowSize.Width;            // #23510 2010.10.31 yyagi add
			this.nウインドウheight = SampleFramework.GameWindowSize.Height;          // 
			this.nフレーム毎スリープms = -1;         // #xxxxx 2011.11.27 yyagi add
			this.n非フォーカス時スリープms = 1;            // #23568 2010.11.04 ikanick add
			this._bGuitar有効 = true;
			this._bDrums有効 = true;
			this.nBGAlpha = 100;
			this.eダメージレベル = Eダメージレベル.普通;
			this.bSTAGEFAILED有効 = true;
			this.bAVI有効 = false;
			this.bBGA有効 = true;
			this.n曲が選択されてからプレビュー音が鳴るまでのウェイトms = 1000;
			this.n曲が選択されてからプレビュー画像が表示開始されるまでのウェイトms = 100;
			//this.bWave再生位置自動調整機能有効 = true;
			this.bWave再生位置自動調整機能有効 = false;
			this.bBGM音を発声する = true;
			this.bScoreIniを出力する = true;
			this.bランダムセレクトで子BOXを検索対象とする = true;
			this.n表示可能な最小コンボ数 = new STDGBVALUE<int>();
			this.n表示可能な最小コンボ数.Drums = 3;
			this.n表示可能な最小コンボ数.Guitar = 2;
			this.n表示可能な最小コンボ数.Bass = 2;
			this.n表示可能な最小コンボ数.Taiko = 3;
			this.FontName = "MS UI Gothic";
			this.ApplyLoudnessMetadata = true;

			// 2018-08-28 twopointzero:
			// There exists a particular large, well-known, well-curated, and
			// regularly-updated collection of content for use with Taiko no
			// Tatsujin simulators. A statistical analysis was performed on the
			// the integrated loudness and true peak loudness of the thousands
			// of songs within this collection as of late August 2018.
			//
			// The analysis allows us to select a target loudness which
			// results in the smallest total amount of loudness adjustment
			// applied to the songs of that collection. The selected target
			// loudness should result in the least-noticeable average
			// adjustment for the most users, assuming their collection is
			// similar to the exemplar.
			//
			// The target loudness which achieves this is -7.4 LUFS.
			this.TargetLoudness = -7.4;

			this.ApplySongVol = false;
			this.SoundEffectLevel = CSound.DefaultSoundEffectLevel;
			this.VoiceLevel = CSound.DefaultVoiceLevel;
			this.SongPreviewLevel = CSound.DefaultSongPreviewLevel;
			this.SongPlaybackLevel = CSound.DefaultSongPlaybackLevel;
			this.KeyboardSoundLevelIncrement = DefaultKeyboardSoundLevelIncrement;
			this.bログ出力 = true;
			this.bSudden = new STDGBVALUE<bool>();
			this.bHidden = new STDGBVALUE<bool>();
			this.bReverse = new STDGBVALUE<bool>();
			this.eRandom = new STDGBVALUE<Eランダムモード>();
			this.bLight = new STDGBVALUE<bool>();
			this.bLeft = new STDGBVALUE<bool>();
			this.e判定位置 = new STDGBVALUE<E判定位置>();       // #33891 2014.6.26 yyagi
			this.判定文字表示位置 = new STDGBVALUE<E判定文字表示位置>();
			this.n譜面スクロール速度 = new STDGBVALUE<int>();
			this.nInputAdjustTimeMs = 0;
			this.nJudgeLinePosOffset = new STDGBVALUE<int>();   // #31602 2013.6.23 yyagi
			this.e判定表示優先度 = E判定表示優先度.Chipより下;
			for (int i = 0; i < Enum.GetValues(typeof(E楽器パート)).Length - 1; i++)
			{
				this.bSudden[i] = false;
				this.bHidden[i] = false;
				this.bReverse[i] = false;
				this.eRandom[i] = Eランダムモード.OFF;
				this.bLight[i] = false;
				this.bLeft[i] = false;
				this.判定文字表示位置[i] = E判定文字表示位置.レーン上;
				this.n譜面スクロール速度[i] = 1;
				this.nJudgeLinePosOffset[i] = 0;
				this.eInvisible[i] = EInvisible.OFF;
				this.nViewerScrollSpeed[i] = 1;
				this.e判定位置[i] = E判定位置.標準;
				//this.e判定表示優先度[ i ] = E判定表示優先度.Chipより下;
			}
			this.n演奏速度 = 20;
			#region [ AutoPlay ]
			this.bAutoPlay = new STAUTOPLAY();

			this.b太鼓パートAutoPlay = true;
			this.b太鼓パートAutoPlay2P = true;
			this.bAuto先生の連打 = true;
			this.bAutoBalloon = true;
			#endregion
			this.nヒット範囲ms = new STRANGE();
			this.nヒット範囲ms.Perfect = 30;
			this.nヒット範囲ms.Great = -1; //使用しません。
			this.nヒット範囲ms.Good = 100;
			this.nヒット範囲ms.Poor = 130;
			this.ConfigIniファイル名 = "";
			this.dicJoystick = new Dictionary<int, string>(10);
			this.tデフォルトのキーアサインに設定する();
			#region [ velocityMin ]
			this.nVelocityMin.LC = 0;                   // #23857 2011.1.31 yyagi VelocityMin
			this.nVelocityMin.HH = 20;
			this.nVelocityMin.SD = 0;
			this.nVelocityMin.BD = 0;
			this.nVelocityMin.HT = 0;
			this.nVelocityMin.LT = 0;
			this.nVelocityMin.FT = 0;
			this.nVelocityMin.CY = 0;
			this.nVelocityMin.RD = 0;
			this.nVelocityMin.LP = 0;
			this.nVelocityMin.LBD = 0;
			#endregion
			this.nRisky = 0;                            // #23539 2011.7.26 yyagi RISKYモード
			this.bIsAutoResultCapture = false;          // #25399 2011.6.9 yyagi リザルト画像自動保存機能ON/OFF

			this.bバッファ入力を行う = true;
			this.bIsAllowedDoubleClickFullscreen = true;    // #26752 2011.11.26 ダブルクリックでのフルスクリーンモード移行を許可
			this.nPoliphonicSounds = 4;                 // #28228 2012.5.1 yyagi レーン毎の最大同時発音数
														// #24820 2013.1.15 yyagi 初期値を4から2に変更。BASS.net使用時の負荷軽減のため。
														// #24820 2013.1.17 yyagi 初期値を4に戻した。動的なミキサー制御がうまく動作しているため。
			this.bIsEnabledSystemMenu = true;           // #28200 2012.5.1 yyagi System Menuの利用可否切替(使用可)
			this.strSystemSkinSubfolderFullName = "";   // #28195 2012.5.2 yyagi 使用中のSkinサブフォルダ名
			this.bTight = false;                        // #29500 2012.9.11 kairera0467 TIGHTモード
			#region [ WASAPI/ASIO ]
			this.nSoundDeviceType = FDK.COS.bIsVistaOrLater ?
				(int)ESoundDeviceTypeForConfig.WASAPI : (int)ESoundDeviceTypeForConfig.ACM; // #24820 2012.12.23 yyagi 初期値はACM | #31927 2013.8.25 yyagi OSにより初期値変更
			this.nWASAPIBufferSizeMs = 50;              // #24820 2013.1.15 yyagi 初期値は50(0で自動設定)
			this.nASIODevice = 0;                       // #24820 2013.1.17 yyagi
														//			this.nASIOBufferSizeMs = 0;					// #24820 2012.12.25 yyagi 初期値は0(自動設定)
			#endregion
			this.bUseOSTimer = false; ;                 // #33689 2014.6.6 yyagi 初期値はfalse (FDKのタイマー。ＦＲＯＭ氏考案の独自タイマー)
			this.bDynamicBassMixerManagement = true;    //
			this.bTimeStretch = false;                  // #23664 2013.2.24 yyagi 初期値はfalse (再生速度変更を、ピッチ変更にて行う)
			this.nDisplayTimesMs = 3000;                // #32072 2013.10.24 yyagi Semi-Invisibleでの、チップ再表示期間
			this.nFadeoutTimeMs = 2000;                 // #32072 2013.10.24 yyagi Semi-Invisibleでの、チップフェードアウト時間

			bViewerVSyncWait = true;
			bViewerShowDebugStatus = true;
			bViewerTimeStretch = false;
			bViewerDrums有効 = true;
			bViewerGuitar有効 = true;



			this.bBranchGuide = false;
			this.nScoreMode = 2;
			this.nDefaultCourse = 3;
			this.nBranchAnime = 1;

			this.b大音符判定 = false;
			this.n両手判定の待ち時間 = 50;

			this.bJudgeCountDisplay = false;

			ShowChara = true;
			ShowDancer = true;
			ShowRunner = true;
			ShowFooter = true;
			ShowMob = true;
			ShowPuchiChara = true;
			ShowBPM = true;

			this.eSTEALTH = Eステルスモード.OFF;
			this.bNoInfo = false;

			//this.bNoMP3Streaming = false;
			this.nMasterVolume = 100;                   // #33700 2014.4.26 yyagi マスターボリュームの設定(WASAPI/ASIO用)

			this.bHispeedRandom = false;
			this.nDefaultSongSort = 2;
			this.eGameMode = EGame.OFF;
			this.bEndingAnime = false;
			this.nPlayerCount = 1; //2017.08.18 kairera0467 マルチプレイ対応
			ShinuchiMode = false;
			FastRender = true;
			MusicPreTimeMs = 1000; // 一秒
			SendDiscordPlayingInformation = true;
			#region[ Ver.K追加 ]
			this.eLaneType = Eレーンタイプ.TypeA;
			this.bDirectShowMode = false;
			#endregion
		}
		public CConfigIni(string iniファイル名)
			: this()
		{
			this.tファイルから読み込み(iniファイル名);
		}


		// メソッド

		public void t指定した入力が既にアサイン済みである場合はそれを全削除する(E入力デバイス DeviceType, int nID, int nCode)
		{
			for (int i = 0; i <= (int)EKeyConfigPart.SYSTEM; i++)
			{
				for (int j = 0; j <= (int)EKeyConfigPad.Capture; j++)
				{
					for (int k = 0; k < 0x10; k++)
					{
						if (((this.KeyAssign[i][j][k].入力デバイス == DeviceType) && (this.KeyAssign[i][j][k].ID == nID)) && (this.KeyAssign[i][j][k].コード == nCode))
						{
							for (int m = k; m < 15; m++)
							{
								this.KeyAssign[i][j][m] = this.KeyAssign[i][j][m + 1];
							}
							this.KeyAssign[i][j][15].入力デバイス = E入力デバイス.不明;
							this.KeyAssign[i][j][15].ID = 0;
							this.KeyAssign[i][j][15].コード = 0;
							k--;
						}
					}
				}
			}
		}
		public void t書き出し(string iniファイル名)
		{
			StreamWriter sw = new StreamWriter(iniファイル名, false, Encoding.GetEncoding("Shift_JIS"));
			sw.WriteLine(";-------------------");

			#region [ System ]
			sw.WriteLine("[System]");
			sw.WriteLine();

#if false        // #23625 2011.1.11 Config.iniからダメージ/回復値の定数変更を行う場合はここを有効にする 087リリースに合わせ機能無効化                                                                                   
	//------------------------------
			sw.WriteLine("; ライフゲージのパラメータ調整(調整完了後削除予定)");
			sw.WriteLine("; GaugeFactorD: ドラムのPerfect, Great,... の回復量(ライフMAXを1.0としたときの値を指定)");
			sw.WriteLine("; GaugeFactorG:  Gt/BsのPerfect, Great,... の回復量(ライフMAXを1.0としたときの値を指定)");
			sw.WriteLine("; DamageFactorD: DamageLevelがSmall, Normal, Largeの時に対するダメージ係数");
			sw.WriteLine("GaugeFactorD={0}, {1}, {2}, {3}, {4}", this.fGaugeFactor[0, 0], this.fGaugeFactor[1, 0], this.fGaugeFactor[2, 0], this.fGaugeFactor[3, 0], this.fGaugeFactor[4, 0]);
			sw.WriteLine("GaugeFactorG={0}, {1}, {2}, {3}, {4}", this.fGaugeFactor[0, 1], this.fGaugeFactor[1, 1], this.fGaugeFactor[2, 1], this.fGaugeFactor[3, 1], this.fGaugeFactor[4, 1]);
			sw.WriteLine("DamageFactor={0}, {1}, {2}", this.fDamageLevelFactor[0], this.fDamageLevelFactor[1], fDamageLevelFactor[2]);
			sw.WriteLine();
	//------------------------------
#endif
			#region [ Version ]
			sw.WriteLine("; リリースバージョン");
			sw.WriteLine("; Release Version.");
			sw.WriteLine("Version={0}", TJAPlayer3.VERSION);
			sw.WriteLine();
			#endregion
			#region [ TJAPath ]
			sw.WriteLine("; 譜面ファイルが格納されているフォルダへのパス。");
			sw.WriteLine(@"; セミコロン(;)で区切ることにより複数のパスを指定できます。（例: d:\tja\;e:\tja2\）");
			sw.WriteLine("; Pathes for TJA data.");
			sw.WriteLine(@"; You can specify many pathes separated with semicolon(;). (e.g. d:\tja\;e:\tja2\)");
			sw.WriteLine("TJAPath={0}", this.str曲データ検索パス);
			sw.WriteLine();
			#endregion
			#region [ スキン関連 ]
			#region [ Skinパスの絶対パス→相対パス変換 ]
			Uri uriRoot = new Uri(System.IO.Path.Combine(TJAPlayer3.strEXEのあるフォルダ, "System" + System.IO.Path.DirectorySeparatorChar));
			if (strSystemSkinSubfolderFullName != null && strSystemSkinSubfolderFullName.Length == 0)
			{
				// Config.iniが空の状態でDTXManiaをViewerとして起動_終了すると、strSystemSkinSubfolderFullName が空の状態でここに来る。
				// → 初期値として Default/ を設定する。
				strSystemSkinSubfolderFullName = System.IO.Path.Combine(TJAPlayer3.strEXEのあるフォルダ, "System" + System.IO.Path.DirectorySeparatorChar + "Default" + System.IO.Path.DirectorySeparatorChar);
			}
			Uri uriPath = new Uri(System.IO.Path.Combine(this.strSystemSkinSubfolderFullName, "." + System.IO.Path.DirectorySeparatorChar));
			string relPath = uriRoot.MakeRelativeUri(uriPath).ToString();               // 相対パスを取得
			relPath = System.Web.HttpUtility.UrlDecode(relPath);                        // デコードする
			relPath = relPath.Replace('/', System.IO.Path.DirectorySeparatorChar);  // 区切り文字が\ではなく/なので置換する
			#endregion
			sw.WriteLine("; 使用するSkinのフォルダ名。");
			sw.WriteLine("; 例えば System\\Default\\Graphics\\... などの場合は、SkinPath=.\\Default\\ を指定します。");
			sw.WriteLine("; Skin folder path.");
			sw.WriteLine("; e.g. System\\Default\\Graphics\\... -> Set SkinPath=.\\Default\\");
			sw.WriteLine("SkinPath={0}", relPath);
			sw.WriteLine();
			sw.WriteLine("; 事前画像描画機能を使うかどうか。(0: OFF, 1: ON)");
			sw.WriteLine("; Use pre-textures render.");
			sw.WriteLine("{0}={1}", nameof(FastRender), FastRender ? 1 : 0);
			sw.WriteLine();
			#endregion
			#region [ Window関連 ]
			sw.WriteLine("; 画面モード(0:ウィンドウ, 1:全画面)");
			sw.WriteLine("; Screen mode. (0:Window, 1:Fullscreen)");
			sw.WriteLine("FullScreen={0}", this.b全画面モード ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; ウインドウモード時の画面幅");                // #23510 2010.10.31 yyagi add
			sw.WriteLine("; A width size in the window mode.");         //
			sw.WriteLine("WindowWidth={0}", this.nウインドウwidth);      //
			sw.WriteLine();                                             //
			sw.WriteLine("; ウインドウモード時の画面高さ");               //
			sw.WriteLine("; A height size in the window mode.");        //
			sw.WriteLine("WindowHeight={0}", this.nウインドウheight);    //
			sw.WriteLine();                                             //
			sw.WriteLine("; ウィンドウモード時の位置X");                            // #30675 2013.02.04 ikanick add
			sw.WriteLine("; X position in the window mode.");                       //
			sw.WriteLine("WindowX={0}", this.n初期ウィンドウ開始位置X);            //
			sw.WriteLine();                                                         //
			sw.WriteLine("; ウィンドウモード時の位置Y");                            //
			sw.WriteLine("; Y position in the window mode.");                       //
			sw.WriteLine("WindowY={0}", this.n初期ウィンドウ開始位置Y);        //
			sw.WriteLine();                                                         //

			sw.WriteLine("; ウインドウをダブルクリックした時にフルスクリーンに移行するか(0:移行しない,1:移行する)");   // #26752 2011.11.27 yyagi
			sw.WriteLine("; Whether double click to go full screen mode or not.(0:No, 1:Yes)");     //
			sw.WriteLine("DoubleClickFullScreen={0}", this.bIsAllowedDoubleClickFullscreen ? 1 : 0);    //
			sw.WriteLine();                                                                             //
			sw.WriteLine("; ALT+SPACEのメニュー表示を抑制するかどうか(0:抑制する 1:抑制しない)");        // #28200 2012.5.1 yyagi
			sw.WriteLine("; Whether ALT+SPACE menu would be masked or not.(0=masked 1=not masked)");    //
			sw.WriteLine("EnableSystemMenu={0}", this.bIsEnabledSystemMenu ? 1 : 0);                    //
			sw.WriteLine();                                                                             //
			sw.WriteLine("; 非フォーカス時のsleep値[ms]");                       // #23568 2011.11.04 ikanick add
			sw.WriteLine("; A sleep time[ms] while the window is inactive.");   //
			sw.WriteLine("BackSleep={0}", this.n非フォーカス時スリープms);     // そのまま引用（苦笑）
			sw.WriteLine();                                                             //
			#endregion
			#region [ フォント ]
			sw.WriteLine("; フォントレンダリングに使用するフォント名");
			sw.WriteLine("; Font name used for font rendering.");
			sw.WriteLine("FontName={0}", this.FontName);
			sw.WriteLine();
			#endregion
			#region [ フレーム処理関連(VSync, フレーム毎のsleep) ]
			sw.WriteLine("; 垂直帰線同期(0:OFF,1:ON)");
			sw.WriteLine("VSyncWait={0}", this.b垂直帰線待ちを行う ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; フレーム毎のsleep値[ms] (-1でスリープ無し, 0以上で毎フレームスリープ。動画キャプチャ等で活用下さい)");   // #xxxxx 2011.11.27 yyagi add
			sw.WriteLine("; A sleep time[ms] per frame.");                          //
			sw.WriteLine("SleepTimePerFrame={0}", this.nフレーム毎スリープms);       //
			sw.WriteLine();                                                             //
			#endregion

			#region [ WASAPI/ASIO関連 ]
			sw.WriteLine("; サウンド出力方式(0=ACM(って今はまだDirectSoundですが), 1=ASIO, 2=WASAPI)");
			sw.WriteLine("; WASAPIはVista以降のOSで使用可能。推奨方式はWASAPI。");
			sw.WriteLine("; なお、WASAPIが使用不可ならASIOを、ASIOが使用不可ならACMを使用します。");
			sw.WriteLine("; Sound device type(0=ACM, 1=ASIO, 2=WASAPI)");
			sw.WriteLine("; WASAPI can use on Vista or later OSs.");
			sw.WriteLine("; If WASAPI is not available, DTXMania try to use ASIO. If ASIO can't be used, ACM is used.");
			sw.WriteLine("SoundDeviceType={0}", (int)this.nSoundDeviceType);
			sw.WriteLine();

			sw.WriteLine("; WASAPI使用時のサウンドバッファサイズ");
			sw.WriteLine("; (0=デバイスに設定されている値を使用, 1～9999=バッファサイズ(単位:ms)の手動指定");
			sw.WriteLine("; WASAPI Sound Buffer Size.");
			sw.WriteLine("; (0=Use system default buffer size, 1-9999=specify the buffer size(ms) by yourself)");
			sw.WriteLine("WASAPIBufferSizeMs={0}", (int)this.nWASAPIBufferSizeMs);
			sw.WriteLine();

			sw.WriteLine("; ASIO使用時のサウンドデバイス");
			sw.WriteLine("; 存在しないデバイスを指定すると、DTXManiaが起動しないことがあります。");
			sw.WriteLine("; Sound device used by ASIO.");
			sw.WriteLine("; Don't specify unconnected device, as the DTXMania may not bootup.");
			string[] asiodev = CEnumerateAllAsioDevices.GetAllASIODevices();
			for (int i = 0; i < asiodev.Length; i++)
			{
				sw.WriteLine("; {0}: {1}", i, asiodev[i]);
			}
			sw.WriteLine("ASIODevice={0}", (int)this.nASIODevice);
			sw.WriteLine();

			//sw.WriteLine( "; ASIO使用時のサウンドバッファサイズ" );
			//sw.WriteLine( "; (0=デバイスに設定されている値を使用, 1～9999=バッファサイズ(単位:ms)の手動指定" );
			//sw.WriteLine( "; ASIO Sound Buffer Size." );
			//sw.WriteLine( "; (0=Use the value specified to the device, 1-9999=specify the buffer size(ms) by yourself)" );
			//sw.WriteLine( "ASIOBufferSizeMs={0}", (int) this.nASIOBufferSizeMs );
			//sw.WriteLine();

			//sw.WriteLine( "; Bass.Mixの制御を動的に行うか否か。" );
			//sw.WriteLine( "; ONにすると、ギター曲などチップ音の多い曲も再生できますが、画面が少しがたつきます。" );
			//sw.WriteLine( "; (0=行わない, 1=行う)" );
			//sw.WriteLine( "DynamicBassMixerManagement={0}", this.bDynamicBassMixerManagement ? 1 : 0 );
			//sw.WriteLine();

			sw.WriteLine("; WASAPI/ASIO時に使用する演奏タイマーの種類");
			sw.WriteLine("; Playback timer used for WASAPI/ASIO");
			sw.WriteLine("; (0=FDK Timer, 1=System Timer)");
			sw.WriteLine("SoundTimerType={0}", this.bUseOSTimer ? 1 : 0);
			sw.WriteLine();

			//sw.WriteLine( "; 全体ボリュームの設定" );
			//sw.WriteLine( "; (0=無音 ～ 100=最大。WASAPI/ASIO時のみ有効)" );
			//sw.WriteLine( "; Master volume settings" );
			//sw.WriteLine( "; (0=Silent - 100=Max)" );
			//sw.WriteLine( "MasterVolume={0}", this.nMasterVolume );
			//sw.WriteLine();

			#endregion
			sw.WriteLine("; 背景画像の半透明割合(0:透明～255:不透明)");
			sw.WriteLine("; Transparency for background image in playing screen.(0:tranaparent - 255:no transparent)");
			sw.WriteLine("BGAlpha={0}", this.nBGAlpha);
			sw.WriteLine();
			sw.WriteLine("; ゲージゼロでSTAGE FAILED (0:OFF, 1:ON)");
			sw.WriteLine("StageFailed={0}", this.bSTAGEFAILED有効 ? 1 : 0);
			sw.WriteLine();
			#region [ AVI/BGA ]
			sw.WriteLine("; AVIの表示(0:OFF, 1:ON)");
			sw.WriteLine("AVI={0}", this.bAVI有効 ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; BGAの表示(0:OFF, 1:ON)");
			sw.WriteLine("BGA={0}", this.bBGA有効 ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; 動画表示モード( 0:表示しない, 1:背景のみ, 2:窓表示のみ, 3:両方)");
			sw.WriteLine("ClipDispType={0}", (int)this.eClipDispType);
			sw.WriteLine();
			#endregion
			#region [ プレビュー音 ]
			sw.WriteLine("; 曲選択からプレビュー音の再生までのウェイト[ms]");
			sw.WriteLine("PreviewSoundWait={0}", this.n曲が選択されてからプレビュー音が鳴るまでのウェイトms);
			sw.WriteLine();
			sw.WriteLine("; 曲選択からプレビュー画像表示までのウェイト[ms]");
			sw.WriteLine("PreviewImageWait={0}", this.n曲が選択されてからプレビュー画像が表示開始されるまでのウェイトms);
			sw.WriteLine();
			#endregion
			//sw.WriteLine( "; Waveの再生位置自動補正(0:OFF, 1:ON)" );
			//sw.WriteLine( "AdjustWaves={0}", this.bWave再生位置自動調整機能有効 ? 1 : 0 );
			#region [ BGM/ドラムヒット音の再生 ]
			sw.WriteLine("; BGM の再生(0:OFF, 1:ON)");
			sw.WriteLine("BGMSound={0}", this.bBGM音を発声する ? 1 : 0);
			sw.WriteLine();
			#endregion
			sw.WriteLine("; 演奏記録（～.score.ini）の出力 (0:OFF, 1:ON)");
			sw.WriteLine("SaveScoreIni={0}", this.bScoreIniを出力する ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; 最小表示コンボ数");
			sw.WriteLine("MinComboDrums={0}", this.n表示可能な最小コンボ数.Drums);
			sw.WriteLine();
			sw.WriteLine("; RANDOM SELECT で子BOXを検索対象に含める (0:OFF, 1:ON)");
			sw.WriteLine("RandomFromSubBox={0}", this.bランダムセレクトで子BOXを検索対象とする ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; 演奏情報を表示する (0:OFF, 1:ON)");
			sw.WriteLine("; Showing playing info on the playing screen. (0:OFF, 1:ON)");
			sw.WriteLine("ShowDebugStatus={0}", this.b演奏情報を表示する ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; BS1770GAIN によるラウドネスメータの測量を適用する (0:OFF, 1:ON)");
			sw.WriteLine("; Apply BS1770GAIN loudness metadata (0:OFF, 1:ON)");
			sw.WriteLine("{0}={1}", nameof(ApplyLoudnessMetadata), this.ApplyLoudnessMetadata ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine($"; BS1770GAIN によるラウドネスメータの目標値 (0). ({CSound.MinimumLufs}-{CSound.MaximumLufs})");
			sw.WriteLine($"; Loudness Target in dB (decibels) relative to full scale (0). ({CSound.MinimumLufs}-{CSound.MaximumLufs})");
			sw.WriteLine("{0}={1}", nameof(TargetLoudness), TargetLoudness);
			sw.WriteLine();
			sw.WriteLine("; .tjaファイルのSONGVOLヘッダを音源の音量に適用する (0:OFF, 1:ON)");
			sw.WriteLine("; Apply SONGVOL (0:OFF, 1:ON)");
			sw.WriteLine("{0}={1}", nameof(ApplySongVol), this.ApplySongVol ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine($"; 効果音の音量 ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
			sw.WriteLine($"; Sound effect level ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
			sw.WriteLine("{0}={1}", nameof(SoundEffectLevel), SoundEffectLevel);
			sw.WriteLine();
			sw.WriteLine($"; 各ボイス、コンボボイスの音量 ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
			sw.WriteLine($"; Voice level ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
			sw.WriteLine("{0}={1}", nameof(VoiceLevel), VoiceLevel);
			sw.WriteLine();
			sw.WriteLine($"; 選曲画面のプレビュー時の音量 ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
			sw.WriteLine($"; Song preview level ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
			sw.WriteLine("{0}={1}", nameof(SongPreviewLevel), SongPreviewLevel);
			sw.WriteLine();
			sw.WriteLine($"; ゲーム中の音源の音量 ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
			sw.WriteLine($"; Song playback level ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
			sw.WriteLine("{0}={1}", nameof(SongPlaybackLevel), SongPlaybackLevel);
			sw.WriteLine();
			sw.WriteLine($"; キーボードによる音量変更の増加量、減少量 ({MinimumKeyboardSoundLevelIncrement}-{MaximumKeyboardSoundLevelIncrement})");
			sw.WriteLine($"; Keyboard sound level increment ({MinimumKeyboardSoundLevelIncrement}-{MaximumKeyboardSoundLevelIncrement})");
			sw.WriteLine("{0}={1}", nameof(KeyboardSoundLevelIncrement), KeyboardSoundLevelIncrement);
			sw.WriteLine();
			sw.WriteLine($"; 音源再生前の空白時間 (ms)");
			sw.WriteLine($"; Blank time before music source to play. (ms)");
			sw.WriteLine("{0}={1}", nameof(MusicPreTimeMs), MusicPreTimeMs);
			sw.WriteLine();
			sw.WriteLine("; ストイックモード(0:OFF, 1:ON)");
			sw.WriteLine("; Stoic mode. (0:OFF, 1:ON)");
			sw.WriteLine("StoicMode={0}", this.bストイックモード ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; バッファ入力モード(0:OFF, 1:ON)");
			sw.WriteLine("; Using Buffered input (0:OFF, 1:ON)");
			sw.WriteLine("BufferedInput={0}", this.bバッファ入力を行う ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; リザルト画像自動保存機能(0:OFF, 1:ON)");                        // #25399 2011.6.9 yyagi
			sw.WriteLine("; Set \"1\" if you'd like to save result screen image automatically");    //
			sw.WriteLine("; when you get hiscore/hiskill.");                                //
			sw.WriteLine("AutoResultCapture={0}", this.bIsAutoResultCapture ? 1 : 0);       //
			sw.WriteLine();
			sw.WriteLine("; Discordに再生中の譜面情報を送信する(0:OFF, 1:ON)");                        // #25399 2011.6.9 yyagi
			sw.WriteLine("; Share Playing .tja file infomation on Discord.");                     //
			sw.WriteLine("{0}={1}", nameof(SendDiscordPlayingInformation), SendDiscordPlayingInformation ? 1 : 0);       //
			sw.WriteLine();
			sw.WriteLine("; 再生速度変更を、ピッチ変更で行うかどうか(0:ピッチ変更, 1:タイムストレッチ"); // #23664 2013.2.24 yyagi
			sw.WriteLine("; (WASAPI/ASIO使用時のみ有効) ");
			sw.WriteLine("; Set \"0\" if you'd like to use pitch shift with PlaySpeed.");   //
			sw.WriteLine("; Set \"1\" for time stretch.");                              //
			sw.WriteLine("; (Only available when you're using using WASAPI or ASIO)");  //
			sw.WriteLine("TimeStretch={0}", this.bTimeStretch ? 1 : 0);                 //
			sw.WriteLine();
			//sw.WriteLine( "; WASAPI/ASIO使用時に、MP3をストリーム再生するかどうか(0:ストリーム再生する, 1:しない)" );			//
			//sw.WriteLine( "; (mp3のシークがおかしくなる場合は、これを1にしてください) " );	//
			//sw.WriteLine( "; Set \"0\" if you'd like to use mp3 streaming playback on WASAPI/ASIO." );		//
			//sw.WriteLine( "; Set \"1\" not to use streaming playback for mp3." );			//
			//sw.WriteLine( "; (If you feel illegal seek with mp3, please set it to 1.)" );	//
			//sw.WriteLine( "NoMP3Streaming={0}", this.bNoMP3Streaming ? 1 : 0 );				//
			//sw.WriteLine();
			sw.WriteLine("; 動画再生にDirectShowを使用する(0:OFF, 1:ON)");
			sw.WriteLine("; 動画再生にDirectShowを使うことによって、再生時の負担を軽減できます。");
			sw.WriteLine("; ただし使用時にはセットアップが必要になるのでご注意ください。");
			sw.WriteLine("DirectShowMode={0}", this.bDirectShowMode ? 1 : 0);
			sw.WriteLine();

			#region [ Adjust ]
			sw.WriteLine("; 判定タイミング調整(-99～99)[ms]");
			sw.WriteLine("; Revision value to adjust judgment timing.");    //
			sw.WriteLine("InputAdjustTime={0}", this.nInputAdjustTimeMs);       //
			sw.WriteLine();

			sw.WriteLine("; 判定ラインの表示位置調整(ドラム, ギター, ベース)(-99～99)[px]");  // #31602 2013.6.23 yyagi 判定ラインの表示位置オフセット
			sw.WriteLine("; Offset value to adjust displaying judgement line for the drums, guitar and bass."); //
			sw.WriteLine("JudgeLinePosOffsetDrums={0}", this.nJudgeLinePosOffset.Drums);        //		
			sw.WriteLine();
			#endregion
			sw.WriteLine("; 「また遊んでね」画面(0:OFF, 1:ON)");
			sw.WriteLine("EndingAnime={0}", this.bEndingAnime ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine(";-------------------");
			#endregion

			#region [ AutoPlay ]
			sw.WriteLine("[AutoPlay]");
			sw.WriteLine();
			sw.WriteLine("; 自動演奏(0:OFF, 1:ON)");
			sw.WriteLine("Taiko={0}", this.b太鼓パートAutoPlay ? 1 : 0);
			sw.WriteLine("Taiko2P={0}", this.b太鼓パートAutoPlay2P ? 1 : 0);
			sw.WriteLine("TaikoAutoRoll={0}", this.bAuto先生の連打 ? 1 : 0);
			sw.WriteLine("TaikoAutoRollColorChange={0}", this.bAuto連打色変更 ? 1 : 0);
			sw.WriteLine("TaikoAutoBalloon={0}", this.bAutoBalloon ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine(";-------------------");
			#endregion

			#region [ HitRange ]
			sw.WriteLine("[HitRange]");
			sw.WriteLine();
			sw.WriteLine("; Perfect～Poor とみなされる範囲[ms]");
			sw.WriteLine("Perfect={0}", this.nヒット範囲ms.Perfect);
			sw.WriteLine("Good={0}", this.nヒット範囲ms.Good);
			sw.WriteLine("Poor={0}", this.nヒット範囲ms.Poor);
			sw.WriteLine();
			sw.WriteLine(";-------------------");
			#endregion

			#region [ Log ]
			sw.WriteLine("[Log]");
			sw.WriteLine();
			sw.WriteLine("; Log出力(0:OFF, 1:ON)");
			sw.WriteLine("OutputLog={0}", this.bログ出力 ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; 曲データ検索に関するLog出力(0:OFF, 1:ON)");
			sw.WriteLine("TraceSongSearch={0}", this.bLog曲検索ログ出力 ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; 画像やサウンドの作成_解放に関するLog出力(0:OFF, 1:ON)");
			sw.WriteLine("TraceCreatedDisposed={0}", this.bLog作成解放ログ出力 ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; DTX読み込み詳細に関するLog出力(0:OFF, 1:ON)");
			sw.WriteLine("TraceDTXDetails={0}", this.bLogDTX詳細ログ出力 ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine(";-------------------");
			#endregion

			#region [ PlayOption ]
			sw.WriteLine("[PlayOption]");
			sw.WriteLine();
			sw.WriteLine("; 各画像の表示設定");
			sw.WriteLine("; キャラクター画像を表示する (0:OFF, 1:ON)");
			sw.WriteLine("ShowChara={0}", ShowChara ? 1 : 0);
			sw.WriteLine("; ダンサー画像を表示する (0:OFF, 1:ON)");
			sw.WriteLine("ShowDancer={0}", ShowDancer ? 1 : 0);
			sw.WriteLine("; ランナー画像を表示する (0:OFF, 1:ON)");
			sw.WriteLine("ShowRunner={0}", ShowRunner ? 1 : 0);
			sw.WriteLine("; モブ画像を表示する (0:OFF, 1:ON)");
			sw.WriteLine("ShowMob={0}", ShowMob ? 1 : 0);
			sw.WriteLine("; フッター画像 (0:OFF, 1:ON)");
			sw.WriteLine("ShowFooter={0}", ShowFooter ? 1 : 0);
			sw.WriteLine("; ぷちキャラ画像 (0:OFF, 1:ON)");
			sw.WriteLine("ShowPuchiChara={0}", ShowPuchiChara ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; BPM表示 (0:OFF, 1:ON)");
			sw.WriteLine("ShowBPM={0}", ShowBPM ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; DARKモード(0:OFF, 1:HALF, 2:FULL)");
			sw.WriteLine("Dark={0}", (int)this.eDark);
			sw.WriteLine();
			/*
			sw.WriteLine( "; スクロール方法(※β版)" );
			sw.WriteLine( "; (0:通常, 1:BMSCROLL, 2:HSSCROLL)" );
			sw.WriteLine( "ScrollMode={0}", (int)this.eScrollMode );
			sw.WriteLine();
			*/
			#region [ SUDDEN ]
			sw.WriteLine("; ドラムSUDDENモード(0:OFF, 1:ON)");
			sw.WriteLine("DrumsSudden={0}", this.bSudden.Drums ? 1 : 0);
			sw.WriteLine();
			#endregion
			#region [ HIDDEN ]
			sw.WriteLine("; ドラムHIDDENモード(0:OFF, 1:ON)");
			sw.WriteLine("DrumsHidden={0}", this.bHidden.Drums ? 1 : 0);
			sw.WriteLine();
			#endregion
			#region [ Invisible ]
			sw.WriteLine("; ドラムチップ非表示モード (0:OFF, 1=SEMI, 2:FULL)");
			sw.WriteLine("; Drums chip invisible mode");
			sw.WriteLine("DrumsInvisible={0}", (int)this.eInvisible.Drums);
			sw.WriteLine();
			//sw.WriteLine( "; Semi-InvisibleでMissった時のチップ再表示時間(ms)" );
			//sw.WriteLine( "InvisibleDisplayTimeMs={0}", (int) this.nDisplayTimesMs );
			//sw.WriteLine();
			//sw.WriteLine( "; Semi-InvisibleでMissってチップ再表示時間終了後のフェードアウト時間(ms)" );
			//sw.WriteLine( "InvisibleFadeoutTimeMs={0}", (int) this.nFadeoutTimeMs );
			//sw.WriteLine();
			#endregion
			sw.WriteLine("; ドラムREVERSEモード(0:OFF, 1:ON)");
			sw.WriteLine("DrumsReverse={0}", this.bReverse.Drums ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; RISKYモード(0:OFF, 1-10)");                                    // #23559 2011.6.23 yyagi
			sw.WriteLine("; RISKY mode. 0=OFF, 1-10 is the times of misses to be Failed."); //
			sw.WriteLine("Risky={0}", this.nRisky);         //
			sw.WriteLine();
			sw.WriteLine("; TIGHTモード(0:OFF, 1:ON)");                                    // #29500 2012.9.11 kairera0467
			sw.WriteLine("; TIGHT mode. 0=OFF, 1=ON ");
			sw.WriteLine("DrumsTight={0}", this.bTight ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; ドラム譜面スクロール速度(0:x0.5, 1:x1.0, 2:x1.5,…,1999:x1000.0)");
			sw.WriteLine("DrumsScrollSpeed={0}", this.n譜面スクロール速度.Taiko);
			sw.WriteLine();
			sw.WriteLine("; 演奏速度(5～40)(→x5/20～x40/20)");
			sw.WriteLine("PlaySpeed={0}", this.n演奏速度);
			sw.WriteLine();

			sw.WriteLine("; デフォルトで選択される難易度");
			sw.WriteLine("DefaultCourse={0}", this.nDefaultCourse);
			sw.WriteLine();
			sw.WriteLine("; 譜面分岐のガイド表示(0:OFF, 1:ON)");
			sw.WriteLine("BranchGuide={0}", this.bGraph.Drums ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; スコア計算方法(0:旧配点, 1:旧筐体配点, 2:新配点)");
			sw.WriteLine("ScoreMode={0}", this.nScoreMode);
			sw.WriteLine();
			sw.WriteLine("; 真打モード (0:OFF, 1:ON)");
			sw.WriteLine("; Fixed score mode (0:OFF, 1:ON)");
			sw.WriteLine("{0}={1}", nameof(ShinuchiMode), ShinuchiMode ? 1 : 0);
			//sw.WriteLine( "; 1ノーツごとのスクロール速度をランダムで変更します。(0:OFF, 1:ON)" );
			//sw.WriteLine( "HispeedRandom={0}", this.bHispeedRandom ? 1 : 0 );
			//sw.WriteLine();
			sw.WriteLine("; 大音符の両手入力待機時間(ms)");
			sw.WriteLine("BigNotesWaitTime={0}", this.n両手判定の待ち時間);
			sw.WriteLine();
			sw.WriteLine("; 大音符の両手判定(0:OFF, 1:ON)");
			sw.WriteLine("BigNotesJudge={0}", this.b大音符判定 ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; NoInfo(0:OFF, 1:ON)");
			sw.WriteLine("NoInfo={0}", this.bNoInfo ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; 譜面分岐のアニメーション(0:7～14, 1:15)");
			sw.WriteLine("BranchAnime={0}", this.nBranchAnime);
			sw.WriteLine();
			sw.WriteLine("; デフォルトの曲ソート(0:絶対パス順, 1:ジャンル名ソートOLD, 2:ジャンル名ソートNEW )");
			sw.WriteLine("0:Path, 1:GenreName(AC8～AC14), 2GenreName(AC15～)");
			sw.WriteLine("DefaultSongSort={0}", this.nDefaultSongSort);
			sw.WriteLine();
			sw.WriteLine("; RANDOMモード(0:OFF, 1:Random, 2:Mirorr 3:SuperRandom, 4:HyperRandom)");
			sw.WriteLine("TaikoRandom={0}", (int)this.eRandom.Taiko);
			sw.WriteLine();
			sw.WriteLine("; STEALTHモード(0:OFF, 1:ドロン, 2:ステルス)");
			sw.WriteLine("TaikoStealth={0}", (int)this.eSTEALTH);
			sw.WriteLine();
			sw.WriteLine("; ゲーム(0:OFF, 1:完走!叩ききりまショー!, 2:完走!叩ききりまショー!(激辛) )");
			sw.WriteLine("GameMode={0}", (int)this.eGameMode);
			sw.WriteLine();
			sw.WriteLine("; JUST(0:OFF, 1:ON)");
			sw.WriteLine("Just={0}", this.bJust ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; 判定数の表示(0:OFF, 1:ON)");
			sw.WriteLine("JudgeCountDisplay={0}", this.bJudgeCountDisplay ? 1 : 0);
			sw.WriteLine();
			sw.WriteLine("; プレイ人数");
			sw.WriteLine("PlayerCount={0}", this.nPlayerCount);
			sw.WriteLine();
			//sw.WriteLine( "; 選曲画面の初期選択難易度(ベータ版)" );
			//sw.WriteLine( "DifficultPriority={0}", this.bJudgeCountDisplay ? 1 : 0 );
			//sw.WriteLine();

			sw.WriteLine(";-------------------");
			#endregion
			#region [ GUID ]
			sw.WriteLine("[GUID]");
			sw.WriteLine();
			foreach (KeyValuePair<int, string> pair in this.dicJoystick)
			{
				sw.WriteLine("JoystickID={0},{1}", pair.Key, pair.Value);
			}
			#endregion
			#region [ DrumsKeyAssign ]
			sw.WriteLine();
			sw.WriteLine(";-------------------");
			sw.WriteLine("; キーアサイン");
			sw.WriteLine(";   項　目：Keyboard → 'K'＋'0'＋キーコード(10進数)");
			sw.WriteLine(";           Mouse    → 'N'＋'0'＋ボタン番号(0～7)");
			sw.WriteLine(";           MIDI In  → 'M'＋デバイス番号1桁(0～9,A～Z)＋ノート番号(10進数)");
			sw.WriteLine(";           Joystick → 'J'＋デバイス番号1桁(0～9,A～Z)＋ 0 ...... Ｘ減少(左)ボタン");
			sw.WriteLine(";                                                         1 ...... Ｘ増加(右)ボタン");
			sw.WriteLine(";                                                         2 ...... Ｙ減少(上)ボタン");
			sw.WriteLine(";                                                         3 ...... Ｙ増加(下)ボタン");
			sw.WriteLine(";                                                         4 ...... Ｚ減少(前)ボタン");
			sw.WriteLine(";                                                         5 ...... Ｚ増加(後)ボタン");
			sw.WriteLine(";                                                         6～133.. ボタン1～128");
			sw.WriteLine(";           これらの項目を 16 個まで指定可能(',' で区切って記述）。");
			sw.WriteLine(";");
			sw.WriteLine(";   表記例：HH=K044,M042,J16");
			sw.WriteLine(";           → HiHat を Keyboard の 44 ('Z'), MidiIn#0 の 42, JoyPad#1 の 6(ボタン1) に割当て");
			sw.WriteLine(";");
			sw.WriteLine(";   ※Joystick のデバイス番号とデバイスとの関係は [GUID] セクションに記してあるものが有効。");
			sw.WriteLine(";");
			sw.WriteLine();
			sw.WriteLine("[DrumsKeyAssign]");
			sw.WriteLine();
			sw.Write("LeftRed=");
			this.tキーの書き出し(sw, this.KeyAssign.Drums.LeftRed);
			sw.WriteLine();
			sw.Write("RightRed=");
			this.tキーの書き出し(sw, this.KeyAssign.Drums.RightRed);
			sw.WriteLine();
			sw.Write("LeftBlue=");                                      // #27029 2012.1.4 from
			this.tキーの書き出し(sw, this.KeyAssign.Drums.LeftBlue);   //
			sw.WriteLine();                                         //
			sw.Write("RightBlue=");                                     // #27029 2012.1.4 from
			this.tキーの書き出し(sw, this.KeyAssign.Drums.RightBlue);  //
			sw.WriteLine();
			sw.Write("LeftRed2P=");
			this.tキーの書き出し(sw, this.KeyAssign.Drums.LeftRed2P);
			sw.WriteLine();
			sw.Write("RightRed2P=");
			this.tキーの書き出し(sw, this.KeyAssign.Drums.RightRed2P);
			sw.WriteLine();
			sw.Write("LeftBlue2P=");                                        // #27029 2012.1.4 from
			this.tキーの書き出し(sw, this.KeyAssign.Drums.LeftBlue2P); //
			sw.WriteLine();                                                 //
			sw.Write("RightBlue2P=");                                       // #27029 2012.1.4 from
			this.tキーの書き出し(sw, this.KeyAssign.Drums.RightBlue2P);    //
			sw.WriteLine();
			sw.WriteLine();
			#endregion
			#region [ SystemkeyAssign ]
			sw.WriteLine("[SystemKeyAssign]");
			sw.WriteLine();
			sw.Write("Capture=");
			this.tキーの書き出し(sw, this.KeyAssign.System.Capture);
			sw.WriteLine();
			sw.WriteLine();
			#endregion

			sw.Close();
		}
		public void tファイルから読み込み(string iniファイル名)
		{
			this.ConfigIniファイル名 = iniファイル名;
			this.bConfigIniが存在している = File.Exists(this.ConfigIniファイル名);
			if (this.bConfigIniが存在している)
			{
				string str;
				this.tキーアサインを全部クリアする();
				using (StreamReader reader = new StreamReader(this.ConfigIniファイル名, Encoding.GetEncoding("Shift_JIS")))
				{
					str = reader.ReadToEnd();
				}
				t文字列から読み込み(str);
				CDTXVersion version = new CDTXVersion(this.strDTXManiaのバージョン);
				//if( version.n整数部 <= 69 )
				//{
				//	this.tデフォルトのキーアサインに設定する();
				//}
			}
		}

		private void t文字列から読み込み(string strAllSettings)  // 2011.4.13 yyagi; refactored to make initial KeyConfig easier.
		{
			Eセクション種別 unknown = Eセクション種別.Unknown;
			string[] delimiter = { "\n" };
			string[] strSingleLine = strAllSettings.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
			foreach (string s in strSingleLine)
			{
				string str = s.Replace('\t', ' ').TrimStart(new char[] { '\t', ' ' });
				if ((str.Length != 0) && (str[0] != ';'))
				{
					try
					{
						string str3;
						string str4;
						if (str[0] == '[')
						{
							#region [ セクションの変更 ]
							//-----------------------------
							StringBuilder builder = new StringBuilder(0x20);
							int num = 1;
							while ((num < str.Length) && (str[num] != ']'))
							{
								builder.Append(str[num++]);
							}
							string str2 = builder.ToString();
							if (str2.Equals("System"))
							{
								unknown = Eセクション種別.System;
							}
							else if (str2.Equals("AutoPlay"))
							{
								unknown = Eセクション種別.AutoPlay;
							}
							else if (str2.Equals("HitRange"))
							{
								unknown = Eセクション種別.HitRange;
							}
							else if (str2.Equals("Log"))
							{
								unknown = Eセクション種別.Log;
							}
							else if (str2.Equals("PlayOption"))
							{
								unknown = Eセクション種別.PlayOption;
							}
							else if (str2.Equals("ViewerOption"))
							{
								unknown = Eセクション種別.ViewerOption;
							}
							else if (str2.Equals("GUID"))
							{
								unknown = Eセクション種別.GUID;
							}
							else if (str2.Equals("DrumsKeyAssign"))
							{
								unknown = Eセクション種別.DrumsKeyAssign;
							}
							else if (str2.Equals("SystemKeyAssign"))
							{
								unknown = Eセクション種別.SystemKeyAssign;
							}
							else if (str2.Equals("Temp"))
							{
								unknown = Eセクション種別.Temp;
							}
							else
							{
								unknown = Eセクション種別.Unknown;
							}
							//-----------------------------
							#endregion
						}
						else
						{
							string[] strArray = str.Split(new char[] { '=' });
							if (strArray.Length == 2)
							{
								str3 = strArray[0].Trim();
								str4 = strArray[1].Trim();
								switch (unknown)
								{
									#region [ [System] ]
									//-----------------------------
									case Eセクション種別.System:
										{
#if false      // #23625 2011.1.11 Config.iniからダメージ/回復値の定数変更を行う場合はここを有効にする 087リリースに合わせ機能無効化                                                                                   
										//----------------------------------------
												if (str3.Equals("GaugeFactorD"))
												{
													int p = 0;
													string[] splittedFactor = str4.Split(',');
													foreach (string s in splittedFactor) {
														this.fGaugeFactor[p++, 0] = Convert.ToSingle(s);
													}
												} else
												if (str3.Equals("GaugeFactorG"))
												{
													int p = 0;
													string[] splittedFactor = str4.Split(',');
													foreach (string s in splittedFactor)
													{
														this.fGaugeFactor[p++, 1] = Convert.ToSingle(s);
													}
												}
												else
												if (str3.Equals("DamageFactor"))
												{
													int p = 0;
													string[] splittedFactor = str4.Split(',');
													foreach (string s in splittedFactor)
													{
														this.fDamageLevelFactor[p++] = Convert.ToSingle(s);
													}
												}
												else
										//----------------------------------------
#endif
											#region [ Version ]
											if (str3.Equals("Version"))
											{
												this.strDTXManiaのバージョン = str4;
											}
											#endregion
											#region [ TJAPath ]
											else if (str3.Equals("TJAPath"))
											{
												this.str曲データ検索パス = str4;
											}
											#endregion
											#region [ skin関係 ]
											else if (str3.Equals("SkinPath"))
											{
												string absSkinPath = str4;
												if (!System.IO.Path.IsPathRooted(str4))
												{
													absSkinPath = System.IO.Path.Combine(TJAPlayer3.strEXEのあるフォルダ, "System");
													absSkinPath = System.IO.Path.Combine(absSkinPath, str4);
													Uri u = new Uri(absSkinPath);
													absSkinPath = u.AbsolutePath.ToString();    // str4内に相対パスがある場合に備える
													absSkinPath = System.Web.HttpUtility.UrlDecode(absSkinPath);                        // デコードする
													absSkinPath = absSkinPath.Replace('/', System.IO.Path.DirectorySeparatorChar);  // 区切り文字が\ではなく/なので置換する
												}
												if (absSkinPath[absSkinPath.Length - 1] != System.IO.Path.DirectorySeparatorChar)   // フォルダ名末尾に\を必ずつけて、CSkin側と表記を統一する
												{
													absSkinPath += System.IO.Path.DirectorySeparatorChar;
												}
												this.strSystemSkinSubfolderFullName = absSkinPath;
											}
											else if (str3.Equals(nameof(FastRender)))
											{
												FastRender = C変換.bONorOFF(str4[0]);
											}
											#endregion
											#region [ Window関係 ]
											else if (str3.Equals("FullScreen"))
											{
												this.b全画面モード = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("WindowX"))        // #30675 2013.02.04 ikanick add
											{
												this.n初期ウィンドウ開始位置X = C変換.n値を文字列から取得して範囲内に丸めて返す(
													str4, 0, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 1, this.n初期ウィンドウ開始位置X);
											}
											else if (str3.Equals("WindowY"))        // #30675 2013.02.04 ikanick add
											{
												this.n初期ウィンドウ開始位置Y = C変換.n値を文字列から取得して範囲内に丸めて返す(
													str4, 0, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 1, this.n初期ウィンドウ開始位置Y);
											}
											else if (str3.Equals("WindowWidth"))        // #23510 2010.10.31 yyagi add
											{
												this.nウインドウwidth = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 1, 65535, this.nウインドウwidth);
												if (this.nウインドウwidth <= 0)
												{
													this.nウインドウwidth = SampleFramework.GameWindowSize.Width;
												}
											}
											else if (str3.Equals("WindowHeight"))       // #23510 2010.10.31 yyagi add
											{
												this.nウインドウheight = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 1, 65535, this.nウインドウheight);
												if (this.nウインドウheight <= 0)
												{
													this.nウインドウheight = SampleFramework.GameWindowSize.Height;
												}
											}
											else if (str3.Equals("DoubleClickFullScreen"))  // #26752 2011.11.27 yyagi
											{
												this.bIsAllowedDoubleClickFullscreen = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("EnableSystemMenu"))       // #28200 2012.5.1 yyagi
											{
												this.bIsEnabledSystemMenu = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("BackSleep"))              // #23568 2010.11.04 ikanick add
											{
												this.n非フォーカス時スリープms = C変換.n値を文字列から取得して範囲内にちゃんと丸めて返す(str4, 0, 50, this.n非フォーカス時スリープms);
											}
											#endregion

											#region [ WASAPI/ASIO関係 ]
											else if (str3.Equals("SoundDeviceType"))
											{
												this.nSoundDeviceType = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 2, this.nSoundDeviceType);
											}
											else if (str3.Equals("WASAPIBufferSizeMs"))
											{
												this.nWASAPIBufferSizeMs = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 9999, this.nWASAPIBufferSizeMs);
											}
											else if (str3.Equals("ASIODevice"))
											{
												string[] asiodev = CEnumerateAllAsioDevices.GetAllASIODevices();
												this.nASIODevice = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, asiodev.Length - 1, this.nASIODevice);
											}
											//else if ( str3.Equals( "ASIOBufferSizeMs" ) )
											//{
											//    this.nASIOBufferSizeMs = C変換.n値を文字列から取得して範囲内に丸めて返す( str4, 0, 9999, this.nASIOBufferSizeMs );
											//}
											//else if ( str3.Equals( "DynamicBassMixerManagement" ) )
											//{
											//    this.bDynamicBassMixerManagement = C変換.bONorOFF( str4[ 0 ] );
											//}
											else if (str3.Equals("SoundTimerType"))         // #33689 2014.6.6 yyagi
											{
												this.bUseOSTimer = C変換.bONorOFF(str4[0]);
											}
											//else if ( str3.Equals( "MasterVolume" ) )
											//{
											//    this.nMasterVolume = C変換.n値を文字列から取得して範囲内に丸めて返す( str4, 0, 100, this.nMasterVolume );
											//}
											#endregion

											#region [ フォント ]
											else if (str3.Equals("FontName"))
											{
												this.FontName = str4;
											}
											#endregion

											else if (str3.Equals("VSyncWait"))
											{
												this.b垂直帰線待ちを行う = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("SleepTimePerFrame"))      // #23568 2011.11.27 yyagi
											{
												this.nフレーム毎スリープms = C変換.n値を文字列から取得して範囲内にちゃんと丸めて返す(str4, -1, 50, this.nフレーム毎スリープms);
											}
											else if (str3.Equals("BGAlpha"))
											{
												this.n背景の透過度 = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 0xff, this.n背景の透過度);
											}
											else if (str3.Equals("DamageLevel"))
											{
												this.eダメージレベル = (Eダメージレベル)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 2, (int)this.eダメージレベル);
											}
											else if (str3.Equals("StageFailed"))
											{
												this.bSTAGEFAILED有効 = C変換.bONorOFF(str4[0]);
											}
											#region [ AVI/BGA ]
											else if (str3.Equals("AVI"))
											{
												this.bAVI有効 = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("BGA"))
											{
												this.bBGA有効 = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("ClipDispType"))
											{
												this.eClipDispType = (EClipDispType)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 3, (int)this.eClipDispType);
											}
											#endregion
											#region [ プレビュー音 ]
											else if (str3.Equals("PreviewSoundWait"))
											{
												this.n曲が選択されてからプレビュー音が鳴るまでのウェイトms = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 0x5f5e0ff, this.n曲が選択されてからプレビュー音が鳴るまでのウェイトms);
											}
											else if (str3.Equals("PreviewImageWait"))
											{
												this.n曲が選択されてからプレビュー画像が表示開始されるまでのウェイトms = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 0x5f5e0ff, this.n曲が選択されてからプレビュー画像が表示開始されるまでのウェイトms);
											}
											#endregion
											//else if( str3.Equals( "AdjustWaves" ) )
											//{
											//	this.bWave再生位置自動調整機能有効 = C変換.bONorOFF( str4[ 0 ] );
											//}
											#region [ BGM/ドラムのヒット音 ]
											else if (str3.Equals("BGMSound"))
											{
												this.bBGM音を発声する = C変換.bONorOFF(str4[0]);
											}
											#endregion
											else if (str3.Equals("SaveScoreIni"))
											{
												this.bScoreIniを出力する = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("RandomFromSubBox"))
											{
												this.bランダムセレクトで子BOXを検索対象とする = C変換.bONorOFF(str4[0]);
											}
											#region [ コンボ数 ]
											else if (str3.Equals("MinComboDrums"))
											{
												this.n表示可能な最小コンボ数.Drums = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 1, 0x1869f, this.n表示可能な最小コンボ数.Drums);
											}
											#endregion
											else if (str3.Equals("ShowDebugStatus"))
											{
												this.b演奏情報を表示する = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals(nameof(ApplyLoudnessMetadata)))
											{
												this.ApplyLoudnessMetadata = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals(nameof(TargetLoudness)))
											{
												this.TargetLoudness = C変換.db値を文字列から取得して範囲内に丸めて返す(str4, CSound.MinimumLufs.ToDouble(), CSound.MaximumLufs.ToDouble(), this.TargetLoudness);
											}
											else if (str3.Equals(nameof(ApplySongVol)))
											{
												this.ApplySongVol = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals(nameof(SoundEffectLevel)))
											{
												this.SoundEffectLevel = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, CSound.MinimumGroupLevel, CSound.MaximumGroupLevel, this.SoundEffectLevel);
											}
											else if (str3.Equals(nameof(VoiceLevel)))
											{
												this.VoiceLevel = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, CSound.MinimumGroupLevel, CSound.MaximumGroupLevel, this.VoiceLevel);
											}
											else if (str3.Equals(nameof(SongPreviewLevel)))
											{
												this.SongPreviewLevel = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, CSound.MinimumGroupLevel, CSound.MaximumGroupLevel, this.SongPreviewLevel);
											}
											else if (str3.Equals(nameof(SongPlaybackLevel)))
											{
												this.SongPlaybackLevel = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, CSound.MinimumGroupLevel, CSound.MaximumGroupLevel, this.SongPlaybackLevel);
											}
											else if (str3.Equals(nameof(KeyboardSoundLevelIncrement)))
											{
												this.KeyboardSoundLevelIncrement = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, MinimumKeyboardSoundLevelIncrement, MaximumKeyboardSoundLevelIncrement, this.KeyboardSoundLevelIncrement);
											}
											else if (str3.Equals(nameof(MusicPreTimeMs)))
											{
												MusicPreTimeMs = int.Parse(str4);
											}
											else if (str3.Equals("StoicMode"))
											{
												this.bストイックモード = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("JudgeDispPriority"))
											{
												this.e判定表示優先度 = (E判定表示優先度)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 1, (int)this.e判定表示優先度);
											}
											else if (str3.Equals("AutoResultCapture"))          // #25399 2011.6.9 yyagi
											{
												this.bIsAutoResultCapture = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals(nameof(SendDiscordPlayingInformation)))
											{
												SendDiscordPlayingInformation = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("TimeStretch"))                // #23664 2013.2.24 yyagi
											{
												this.bTimeStretch = C変換.bONorOFF(str4[0]);
											}
											#region [ AdjustTime ]
											else if (str3.Equals("InputAdjustTime"))
											{
												this.nInputAdjustTimeMs = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, -99, 99, this.nInputAdjustTimeMs);
											}
											else if (str3.Equals("JudgeLinePosOffsetDrums"))        // #31602 2013.6.23 yyagi
											{
												this.nJudgeLinePosOffset.Drums = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, -99, 99, this.nJudgeLinePosOffset.Drums);
											}
											else if (str3.Equals("JudgeLinePosOffsetGuitar"))       // #31602 2013.6.23 yyagi
											{
												this.nJudgeLinePosOffset.Guitar = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, -99, 99, this.nJudgeLinePosOffset.Guitar);
											}
											else if (str3.Equals("JudgeLinePosOffsetBass"))         // #31602 2013.6.23 yyagi
											{
												this.nJudgeLinePosOffset.Bass = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, -99, 99, this.nJudgeLinePosOffset.Bass);
											}
											else if (str3.Equals("JudgeLinePosModeGuitar")) // #33891 2014.6.26 yyagi
											{
												this.e判定位置.Guitar = (E判定位置)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 2, (int)this.e判定位置.Guitar);
											}
											else if (str3.Equals("JudgeLinePosModeBass"))       // #33891 2014.6.26 yyagi
											{
												this.e判定位置.Bass = (E判定位置)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 2, (int)this.e判定位置.Bass);
											}
											#endregion
											else if (str3.Equals("BufferedInput"))
											{
												this.bバッファ入力を行う = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("PolyphonicSounds"))       // #28228 2012.5.1 yyagi
											{
												this.nPoliphonicSounds = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 1, 8, this.nPoliphonicSounds);
											}
											#region [ VelocityMin ]
											else if (str3.Equals("LCVelocityMin"))          // #23857 2010.12.12 yyagi
											{
												this.nVelocityMin.LC = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 127, this.nVelocityMin.LC);
											}
											else if (str3.Equals("HHVelocityMin"))
											{
												this.nVelocityMin.HH = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 127, this.nVelocityMin.HH);
											}
											else if (str3.Equals("SDVelocityMin"))          // #23857 2011.1.31 yyagi
											{
												this.nVelocityMin.SD = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 127, this.nVelocityMin.SD);
											}
											else if (str3.Equals("BDVelocityMin"))          // #23857 2011.1.31 yyagi
											{
												this.nVelocityMin.BD = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 127, this.nVelocityMin.BD);
											}
											else if (str3.Equals("HTVelocityMin"))          // #23857 2011.1.31 yyagi
											{
												this.nVelocityMin.HT = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 127, this.nVelocityMin.HT);
											}
											else if (str3.Equals("LTVelocityMin"))          // #23857 2011.1.31 yyagi
											{
												this.nVelocityMin.LT = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 127, this.nVelocityMin.LT);
											}
											else if (str3.Equals("FTVelocityMin"))          // #23857 2011.1.31 yyagi
											{
												this.nVelocityMin.FT = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 127, this.nVelocityMin.FT);
											}
											else if (str3.Equals("CYVelocityMin"))          // #23857 2011.1.31 yyagi
											{
												this.nVelocityMin.CY = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 127, this.nVelocityMin.CY);
											}
											else if (str3.Equals("RDVelocityMin"))          // #23857 2011.1.31 yyagi
											{
												this.nVelocityMin.RD = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 127, this.nVelocityMin.RD);
											}
											#endregion
											//else if ( str3.Equals( "NoMP3Streaming" ) )
											//{
											//    this.bNoMP3Streaming = C変換.bONorOFF( str4[ 0 ] );
											//}
											#region[ Ver.K追加 ]
											else if (str3.Equals("DirectShowMode"))     // #28228 2012.5.1 yyagi
											{
												this.bDirectShowMode = C変換.bONorOFF(str4[0]); ;
											}
											#endregion
											else if (str3.Equals("EndingAnime"))
											{
												this.bEndingAnime = C変換.bONorOFF(str4[0]);
											}

											continue;
										}
									//-----------------------------
									#endregion

									#region [ [AutoPlay] ]
									//-----------------------------
									case Eセクション種別.AutoPlay:
										if (str3.Equals("Taiko"))
										{
											this.b太鼓パートAutoPlay = C変換.bONorOFF(str4[0]);
										}
										else if (str3.Equals("Taiko2P"))
										{
											this.b太鼓パートAutoPlay2P = C変換.bONorOFF(str4[0]);
										}
										else if (str3.Equals("TaikoAutoRoll"))
										{
											this.bAuto先生の連打 = C変換.bONorOFF(str4[0]);
										}
										else if (str3.Equals("TaikoAutoRollColorChange"))
										{
											this.bAuto連打色変更 = C変換.bONorOFF(str4[0]);
										}
										else if (str3.Equals("TaikoAutoBalloon"))
										{
											this.bAutoBalloon = C変換.bONorOFF(str4[0]);
										}
										continue;
									//-----------------------------
									#endregion

									#region [ [HitRange] ]
									//-----------------------------
									case Eセクション種別.HitRange:
										if (str3.Equals("Perfect"))
										{
											this.nヒット範囲ms.Perfect = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 0x3e7, this.nヒット範囲ms.Perfect);
										}
										else if (str3.Equals("Great"))
										{
											this.nヒット範囲ms.Great = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 0x3e7, this.nヒット範囲ms.Great);
										}
										else if (str3.Equals("Good"))
										{
											this.nヒット範囲ms.Good = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 0x3e7, this.nヒット範囲ms.Good);
										}
										else if (str3.Equals("Poor"))
										{
											this.nヒット範囲ms.Poor = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 0x3e7, this.nヒット範囲ms.Poor);
										}
										continue;
									//-----------------------------
									#endregion



									#region [ [Log] ]
									//-----------------------------
									case Eセクション種別.Log:
										{
											if (str3.Equals("OutputLog"))
											{
												this.bログ出力 = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("TraceCreatedDisposed"))
											{
												this.bLog作成解放ログ出力 = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("TraceDTXDetails"))
											{
												this.bLogDTX詳細ログ出力 = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("TraceSongSearch"))
											{
												this.bLog曲検索ログ出力 = C変換.bONorOFF(str4[0]);
											}
											continue;
										}
									//-----------------------------
									#endregion

									#region [ [PlayOption] ]
									//-----------------------------
									case Eセクション種別.PlayOption:
										{
											if (str3.Equals("ShowChara"))
											{
												ShowChara = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("ShowDancer"))
											{
												ShowDancer = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("ShowRunner"))
											{
												ShowRunner = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("ShowMob"))
											{
												ShowMob = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("ShowFooter"))
											{
												ShowFooter = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("ShowPuchiChara"))
											{
												ShowPuchiChara = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("ShowBPM"))
											{
												ShowBPM = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("Dark"))
											{
												this.eDark = (Eダークモード)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 2, (int)this.eDark);
											}
											else if (str3.Equals("ScrollMode"))
											{
												this.eScrollMode = (EScrollMode)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 2, 0);
											}
											/*
											else if( str3.Equals( "DrumsGraph" ) )  // #24074 2011.01.23 addikanick
											{
												this.bGraph.Drums = C変換.bONorOFF( str4[ 0 ] );
											}
											*/
											#region [ Sudden ]
											else if (str3.Equals("DrumsSudden"))
											{
												this.bSudden.Drums = C変換.bONorOFF(str4[0]);
											}
											#endregion
											#region [ Hidden ]
											else if (str3.Equals("DrumsHidden"))
											{
												this.bHidden.Drums = C変換.bONorOFF(str4[0]);
											}
											#endregion
											#region [ Invisible ]
											else if (str3.Equals("DrumsInvisible"))
											{
												this.eInvisible.Drums = (EInvisible)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 2, (int)this.eInvisible.Drums);
											}
											//else if ( str3.Equals( "InvisibleDisplayTimeMs" ) )
											//{
											//    this.nDisplayTimesMs = C変換.n値を文字列から取得して範囲内に丸めて返す( str4, 0, 9999999, (int) this.nDisplayTimesMs );
											//}
											//else if ( str3.Equals( "InvisibleFadeoutTimeMs" ) )
											//{
											//    this.nFadeoutTimeMs = C変換.n値を文字列から取得して範囲内に丸めて返す( str4, 0, 9999999, (int) this.nFadeoutTimeMs );
											//}
											#endregion
											else if (str3.Equals("DrumsReverse"))
											{
												this.bReverse.Drums = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("DrumsPosition"))
											{
												this.判定文字表示位置.Drums = (E判定文字表示位置)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 2, (int)this.判定文字表示位置.Drums);
											}
											else if (str3.Equals("DrumsScrollSpeed"))
											{
												this.n譜面スクロール速度.Taiko = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 0x7cf, this.n譜面スクロール速度.Taiko);
											}
											else if (str3.Equals("PlaySpeed"))
											{
												this.n演奏速度 = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 5, 40, this.n演奏速度);
											}
											//else if ( str3.Equals( "JudgeDispPriorityDrums" ) )
											//{
											//    this.e判定表示優先度.Drums = (E判定表示優先度) C変換.n値を文字列から取得して範囲内に丸めて返す( str4, 0, 1, (int) this.e判定表示優先度.Drums );
											//}
											//else if ( str3.Equals( "JudgeDispPriorityGuitar" ) )
											//{
											//    this.e判定表示優先度.Guitar = (E判定表示優先度) C変換.n値を文字列から取得して範囲内に丸めて返す( str4, 0, 1, (int) this.e判定表示優先度.Guitar );
											//}
											//else if ( str3.Equals( "JudgeDispPriorityBass" ) )
											//{
											//    this.e判定表示優先度.Bass = (E判定表示優先度) C変換.n値を文字列から取得して範囲内に丸めて返す( str4, 0, 1, (int) this.e判定表示優先度.Bass );
											//}
											else if (str3.Equals("Risky"))                  // #23559 2011.6.23  yyagi
											{
												this.nRisky = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 10, this.nRisky);
											}
											else if (str3.Equals("DrumsTight"))
											{
												this.bTight = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("BranchGuide"))
											{
												this.bBranchGuide = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("DefaultCourse")) //2017.01.30 DD
											{
												this.nDefaultCourse = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 4, this.nDefaultCourse);
											}
											else if (str3.Equals("ScoreMode"))
											{
												this.nScoreMode = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 3, this.nScoreMode);
											}
											else if (str3.Equals("HispeedRandom"))
											{
												this.bHispeedRandom = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("BigNotesWaitTime"))
											{
												this.n両手判定の待ち時間 = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 1, 100, this.n両手判定の待ち時間);
											}
											else if (str3.Equals("BigNotesJudge"))
											{
												this.b大音符判定 = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("BranchAnime"))
											{
												this.nBranchAnime = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 1, this.nBranchAnime);
											}
											else if (str3.Equals("NoInfo"))
											{
												this.bNoInfo = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("DefaultSongSort"))
											{
												this.nDefaultSongSort = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 2, this.nDefaultSongSort);
											}
											else if (str3.Equals("TaikoRandom"))
											{
												this.eRandom.Taiko = (Eランダムモード)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 4, (int)this.eRandom.Taiko);
											}
											else if (str3.Equals("TaikoStealth"))
											{
												this.eSTEALTH = (Eステルスモード)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 3, (int)this.eSTEALTH);
											}
											else if (str3.Equals("GameMode"))
											{
												this.eGameMode = (EGame)C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 2, (int)this.eGameMode);
											}
											else if (str3.Equals("JudgeCountDisplay"))
											{
												this.bJudgeCountDisplay = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("Just"))
											{
												this.bJust = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("PlayerCount"))
											{
												this.nPlayerCount = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 1, 2, this.nPlayerCount);
											}
											else if (str3.Equals(nameof(ShinuchiMode)))
											{
												ShinuchiMode = C変換.bONorOFF(str4[0]);
											}
											continue;
										}
									//-----------------------------
									#endregion

									#region [ [ViewerOption] ]
									//-----------------------------
									case Eセクション種別.ViewerOption:
										{
											if (str3.Equals("ViewerDrumsScrollSpeed"))
											{
												this.nViewerScrollSpeed.Drums = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 1999, this.nViewerScrollSpeed.Drums);
											}
											else if (str3.Equals("ViewerGuitarScrollSpeed"))
											{
												this.nViewerScrollSpeed.Guitar = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 1999, this.nViewerScrollSpeed.Guitar);
											}
											else if (str3.Equals("ViewerBassScrollSpeed"))
											{
												this.nViewerScrollSpeed.Bass = C変換.n値を文字列から取得して範囲内に丸めて返す(str4, 0, 1999, this.nViewerScrollSpeed.Bass);
											}
											else if (str3.Equals("ViewerVSyncWait"))
											{
												this.bViewerVSyncWait = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("ViewerShowDebugStatus"))
											{
												this.bViewerShowDebugStatus = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("ViewerTimeStretch"))
											{
												this.bViewerTimeStretch = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("ViewerGuitar"))
											{
												this.bViewerGuitar有効 = C変換.bONorOFF(str4[0]);
											}
											else if (str3.Equals("ViewerDrums"))
											{
												this.bViewerDrums有効 = C変換.bONorOFF(str4[0]);
											}
											continue;
										}
									//-----------------------------
									#endregion

									#region [ [GUID] ]
									//-----------------------------
									case Eセクション種別.GUID:
										if (str3.Equals("JoystickID"))
										{
											this.tJoystickIDの取得(str4);
										}
										continue;
									//-----------------------------
									#endregion

									#region [ [DrumsKeyAssign] ]
									//-----------------------------
									case Eセクション種別.DrumsKeyAssign:
										{
											if (str3.Equals("LeftRed"))
											{
												this.tキーの読み出しと設定(str4, this.KeyAssign.Drums.LeftRed);
											}
											else if (str3.Equals("RightRed"))
											{
												this.tキーの読み出しと設定(str4, this.KeyAssign.Drums.RightRed);
											}
											else if (str3.Equals("LeftBlue"))                                       // #27029 2012.1.4 from
											{                                                                   //
												this.tキーの読み出しと設定(str4, this.KeyAssign.Drums.LeftBlue);  //
											}                                                                   //
											else if (str3.Equals("RightBlue"))                                      // #27029 2012.1.4 from
											{                                                                   //
												this.tキーの読み出しと設定(str4, this.KeyAssign.Drums.RightBlue); //
											}

											else if (str3.Equals("LeftRed2P"))
											{
												this.tキーの読み出しと設定(str4, this.KeyAssign.Drums.LeftRed2P);
											}
											else if (str3.Equals("RightRed2P"))
											{
												this.tキーの読み出しと設定(str4, this.KeyAssign.Drums.RightRed2P);
											}
											else if (str3.Equals("LeftBlue2P"))                                     // #27029 2012.1.4 from
											{                                                                   //
												this.tキーの読み出しと設定(str4, this.KeyAssign.Drums.LeftBlue2P);    //
											}                                                                   //
											else if (str3.Equals("RightBlue2P"))                                        // #27029 2012.1.4 from
											{                                                                   //
												this.tキーの読み出しと設定(str4, this.KeyAssign.Drums.RightBlue2P);   //
											}

											continue;
										}
									//-----------------------------
									#endregion

									#region [ [SystemKeyAssign] ]
									//-----------------------------
									case Eセクション種別.SystemKeyAssign:
										if (str3.Equals("Capture"))
										{
											this.tキーの読み出しと設定(str4, this.KeyAssign.System.Capture);
										}
										continue;
										//-----------------------------
										#endregion
								}
							}
						}
						continue;
					}
					catch (Exception exception)
					{
						Trace.TraceError(exception.ToString());
						Trace.TraceError("例外が発生しましたが処理を継続します。 (93c4c5cd-4996-4e8c-a82f-a179ff590b44)");
						continue;
					}
				}
			}
		}

		/// <summary>
		/// ギターとベースのキーアサイン入れ替え
		/// </summary>
		//public void SwapGuitarBassKeyAssign()		// #24063 2011.1.16 yyagi
		//{
		//    for ( int j = 0; j <= (int)EKeyConfigPad.Capture; j++ )
		//    {
		//        CKeyAssign.STKEYASSIGN t; //= new CConfigIni.CKeyAssign.STKEYASSIGN();
		//        for ( int k = 0; k < 16; k++ )
		//        {
		//            t = this.KeyAssign[ (int)EKeyConfigPart.GUITAR ][ j ][ k ];
		//            this.KeyAssign[ (int)EKeyConfigPart.GUITAR ][ j ][ k ] = this.KeyAssign[ (int)EKeyConfigPart.BASS ][ j ][ k ];
		//            this.KeyAssign[ (int)EKeyConfigPart.BASS ][ j ][ k ] = t;
		//        }
		//    }
		//    this.bIsSwappedGuitarBass = !bIsSwappedGuitarBass;
		//}


		// その他

		#region [ private ]
		//-----------------
		private enum Eセクション種別
		{
			Unknown,
			System,
			Log,
			PlayOption,
			ViewerOption,
			AutoPlay,
			HitRange,
			GUID,
			DrumsKeyAssign,
			SystemKeyAssign,
			Temp,
		}

		private bool _bDrums有効;
		private bool _bGuitar有効;
		private bool bConfigIniが存在している;
		private string ConfigIniファイル名;

		private void tJoystickIDの取得(string strキー記述)
		{
			string[] strArray = strキー記述.Split(new char[] { ',' });
			if (strArray.Length >= 2)
			{
				int result = 0;
				if ((int.TryParse(strArray[0], out result) && (result >= 0)) && (result <= 9))
				{
					if (this.dicJoystick.ContainsKey(result))
					{
						this.dicJoystick.Remove(result);
					}
					this.dicJoystick.Add(result, strArray[1]);
				}
			}
		}
		private void tキーアサインを全部クリアする()
		{
			this.KeyAssign = new CKeyAssign();
			for (int i = 0; i <= (int)EKeyConfigPart.SYSTEM; i++)
			{
				for (int j = 0; j <= (int)EKeyConfigPad.Capture; j++)
				{
					this.KeyAssign[i][j] = new CKeyAssign.STKEYASSIGN[16];
					for (int k = 0; k < 16; k++)
					{
						this.KeyAssign[i][j][k] = new CKeyAssign.STKEYASSIGN(E入力デバイス.不明, 0, 0);
					}
				}
			}
		}
		private void tキーの書き出し(StreamWriter sw, CKeyAssign.STKEYASSIGN[] assign)
		{
			bool flag = true;
			for (int i = 0; i < 0x10; i++)
			{
				if (assign[i].入力デバイス == E入力デバイス.不明)
				{
					continue;
				}
				if (!flag)
				{
					sw.Write(',');
				}
				flag = false;
				switch (assign[i].入力デバイス)
				{
					case E入力デバイス.キーボード:
						sw.Write('K');
						break;

					case E入力デバイス.MIDI入力:
						sw.Write('M');
						break;

					case E入力デバイス.ジョイパッド:
						sw.Write('J');
						break;

					case E入力デバイス.マウス:
						sw.Write('N');
						break;
				}
				sw.Write("{0}{1}", "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(assign[i].ID, 1), assign[i].コード);   // #24166 2011.1.15 yyagi: to support ID > 10, change 2nd character from Decimal to 36-numeral system. (e.g. J1023 -> JA23)
			}
		}
		private void tキーの読み出しと設定(string strキー記述, CKeyAssign.STKEYASSIGN[] assign)
		{
			string[] strArray = strキー記述.Split(new char[] { ',' });
			for (int i = 0; (i < strArray.Length) && (i < 0x10); i++)
			{
				E入力デバイス e入力デバイス;
				int id;
				int code;
				string str = strArray[i].Trim().ToUpper();
				if (str.Length >= 3)
				{
					e入力デバイス = E入力デバイス.不明;
					switch (str[0])
					{
						case 'J':
							e入力デバイス = E入力デバイス.ジョイパッド;
							break;

						case 'K':
							e入力デバイス = E入力デバイス.キーボード;
							break;

						case 'L':
							continue;

						case 'M':
							e入力デバイス = E入力デバイス.MIDI入力;
							break;

						case 'N':
							e入力デバイス = E入力デバイス.マウス;
							break;
					}
				}
				else
				{
					continue;
				}
				id = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(str[1]);    // #24166 2011.1.15 yyagi: to support ID > 10, change 2nd character from Decimal to 36-numeral system. (e.g. J1023 -> JA23)
				if (((id >= 0) && int.TryParse(str.Substring(2), out code)) && ((code >= 0) && (code <= 0xff)))
				{
					this.t指定した入力が既にアサイン済みである場合はそれを全削除する(e入力デバイス, id, code);
					assign[i].入力デバイス = e入力デバイス;
					assign[i].ID = id;
					assign[i].コード = code;
				}
			}
		}
		private void tデフォルトのキーアサインに設定する()
		{
			this.tキーアサインを全部クリアする();

			string strDefaultKeyAssign = @"
[DrumsKeyAssign]
LeftRed=K015
RightRed=K019
LeftBlue=K013
RightBlue=K020
LeftRed2P=
RightRed2P=
LeftBlue2P=
RightBlue2P=

[SystemKeyAssign]
Capture=K065
";
			t文字列から読み込み(strDefaultKeyAssign);
		}
		//-----------------
		#endregion


		public event PropertyChangedEventHandler PropertyChanged;

		private bool SetProperty<T>(ref T storage, T value, string propertyName = null)
		{
			if (Equals(storage, value))
			{
				return false;
			}

			storage = value;
			OnPropertyChanged(propertyName);
			return true;
		}

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
