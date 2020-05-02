using EasyExploits;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BloxSense_v1
{
    // Token: 0x02000002 RID: 2
    public partial class Form1 : Form
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00002050
        public Form1()
        {
            InitializeComponent();
        }

        // Token: 0x06000002 RID: 2 RVA: 0x0000207C File Offset: 0x0000207C
        private void Form1_Load(object sender, EventArgs e)
        {
            bool flag = !logined;
            if (flag)
            {
                Form form = new Form2();
                logined = true;
                form.ShowDialog();
            }
        }

        // Token: 0x06000003 RID: 3 RVA: 0x000020AD File Offset: 0x000020AD
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Token: 0x06000004 RID: 4 RVA: 0x000020B6 File Offset: 0x000020B6
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000005 RID: 5 RVA: 0x000020BC File Offset: 0x000020BC
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            bool flag = e.Button != MouseButtons.Left;
            if (flag)
            {
                MouseHook = e.Location;
            }
            bool flag2 = logined;
            if (flag2)
            {
                base.Location = new Point((Size)base.Location - (Size)MouseHook + (Size)e.Location);
            }
        }

        // Token: 0x06000006 RID: 6 RVA: 0x00002130 File Offset: 0x00002130
        private void button2_Click(object sender, EventArgs e)
        {
            Combat.Visible = true;
            AntiAims.Visible = false;
            misc.Visible = false;
            visuals.Visible = false;
            setings1.Visible = false;
            setings2.Visible = false;
        }

        // Token: 0x06000007 RID: 7 RVA: 0x0000218C File Offset: 0x0000218C
        private void button4_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("print('Rainbow carpet, script by Morphix For project \"BloxSense V1\"') \nlocal player = game:GetService('Players').LocalPlayer local mouse = player:GetMouse() mouse.KeyDown:connect(function(key) if key:lower() == 'g' or key:upper() == 'G' then for i = 1,6 do wait(0.085) x = Instance.new('Part',game:GetService('Workspace')) x.Size = Vector3.new(10,0,10) x.TopSurface = 'Smooth' x.Anchored = true x.BrickColor = BrickColor.random()  x.CFrame = CFrame.new(player.Character.UpperTorso.Position) + Vector3.new(0,-3,0) game.Debris:AddItem(x, 3) end end end)");
        }

        // Token: 0x06000008 RID: 8 RVA: 0x000021A0 File Offset: 0x000021A0
        private void button3_Click(object sender, EventArgs e)
        {
            Combat.Visible = false;
            AntiAims.Visible = true;
            misc.Visible = false;
            visuals.Visible = false;
            setings1.Visible = false;
            setings2.Visible = false;
        }

        // Token: 0x06000009 RID: 9 RVA: 0x000021FC File Offset: 0x000021FC
        private void button15_Click(object sender, EventArgs e)
        {
            bool flag = trackBar1.Value < 100;
            if (flag)
            {
                bool flag2 = MessageBox.Show("This Speed so small, Are you sure?", "Helper", MessageBoxButtons.YesNo) == DialogResult.Yes;
                if (flag2)
                {
                    bool flag3 = MessageBox.Show("This Function can crash, and very unstable. Are you sure?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes;
                    if (flag3)
                    {
                        MessageBox.Show("if you activate this function you will probably become gay. ARE YOU SURE!?!?");
                        api.ExecuteScript(string.Format("print('AntiAims, script by Morphix For project \"BloxSense V1\"') \nlocal spin_power = {0}\ngame:GetService('RunService').Stepped:connect(function()\ngame.Players.LocalPlayer.Character.Head.CanCollide = false\ngame.Players.LocalPlayer.Character.UpperTorso.CanCollide = false\ngame.Players.LocalPlayer.Character.LowerTorso.CanCollide = false\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CanCollide = false\nend)\nwait(.1)\nlocal bambam = Instance.new('BodyThrust')\nbambam.Parent = game.Players.LocalPlayer.Character.HumanoidRootPart\nbambam.Force = Vector3.new(spin_power,0,spin_power)\nbambam.Location = game.Players.LocalPlayer.Character.HumanoidRootPart.Position", trackBar1.Value));
                    }
                }
            }
            else
            {
                bool flag4 = MessageBox.Show("This Function can crash, and very unstable. Are you sure?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes;
                if (flag4)
                {
                    api.ExecuteScript(string.Format("print('AntiAims, script by Morphix For project \"BloxSense V1\"') \nlocal spin_power = {0}\ngame:GetService('RunService').Stepped:connect(function()\ngame.Players.LocalPlayer.Character.Head.CanCollide = false\ngame.Players.LocalPlayer.Character.UpperTorso.CanCollide = false\ngame.Players.LocalPlayer.Character.LowerTorso.CanCollide = false\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CanCollide = false\nend)\nwait(.1)\nlocal bambam = Instance.new('BodyThrust')\nbambam.Parent = game.Players.LocalPlayer.Character.HumanoidRootPart\nbambam.Force = Vector3.new(spin_power,0,spin_power)\nbambam.Location = game.Players.LocalPlayer.Character.HumanoidRootPart.Position", trackBar1.Value));
                }
            }
        }

        // Token: 0x0600000A RID: 10 RVA: 0x000022C5 File Offset: 0x000022C5
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = string.Format("Speed: {0}", trackBar1.Value);
        }

        // Token: 0x0600000B RID: 11 RVA: 0x000022EE File Offset: 0x000022EE
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It's Teleport exploit - Ctrl Tp (Ctrl + mouse)", "Atention");
            api.ExecuteScript("print('Clict Tp, script by Morphix For project \"BloxSense V1\"') \nlocal Player = game.Players.LocalPlayer\nlocal Mouse = Player:GetMouse()\nlocal UserInputService = game:GetService('UserInputService')\nlocal HoldingControl = false\nMouse.Button1Down:connect(function()\nif HoldingControl then\nPlayer.Character:MoveTo(Mouse.Hit.p)\nend\nend) \nUserInputService.InputBegan:connect(function(Input, Processed)\nif Input.UserInputType == Enum.UserInputType.Keyboard then\nif Input.KeyCode == Enum.KeyCode.LeftControl then\nHoldingControl = true\nelseif Input.KeyCode == Enum.KeyCode.RightControl then\nHoldingControl = true\nend\nend\nend) \nUserInputService.InputEnded:connect(function(Input, Processed)\nif Input.UserInputType == Enum.UserInputType.Keyboard then\nif Input.KeyCode == Enum.KeyCode.LeftControl then\nHoldingControl = false\nelseif Input.KeyCode == Enum.KeyCode.RightControl then\nHoldingControl = false\nend\nend\nend)");
        }

        // Token: 0x0600000C RID: 12 RVA: 0x00002312 File Offset: 0x00002312
        private void button6_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("print('Btools, script by Morphix For project \"BloxSense V1\"') \ngame.StarterGui:SetCoreGuiEnabled(Enum.CoreGuiType.Backpack,true)\nforindex,childinpairs(game:GetService('Workspace'):GetChildren())do\nifchild.ClassName=='Part'then\nchild.Locked=false\nend\nifchild.ClassName=='MeshPart'then\nchild.Locked=false\nend\nifchild.ClassName=='UnionOperation'then\nchild.Locked=false\nend\nifchild.ClassName=='Model'then\nforindex,chilinpairs(child:GetChildren())do\nifchil.ClassName=='Part'then\nchil.Locked=false\nend\nifchil.ClassName=='MeshPart'then\nchil.Locked=false\nend\nifchil.ClassName=='UnionOperation'then\nchil.Locked=false\nend\nifchil.ClassName=='Model'then\nforindex,childeinpairs(chil:GetChildren())do\nifchilde.ClassName=='Part'then\nchilde.Locked=false\nend\nifchilde.ClassName=='MeshPart'then\nchilde.Locked=false\nend\nifchilde.ClassName=='UnionOperation'then\nchilde.Locked=false\nend\nifchilde.ClassName=='Model'then\nforindex,childeoinpairs(childe:GetChildren())do\nifchildeo.ClassName=='Part'then\nchildeo.Locked=false\nend\nifchildeo.ClassName=='MeshPart'then\nchildeo.Locked=false\nend\nifchildeo.ClassName=='UnionOperation'then\nchildeo.Locked=false\nend\nifchildeo.ClassName=='Model'then\nend\nend\nend\nend\nend\nend\nend\nend\nc=Instance.new('HopperBin',game:GetService('Players').LocalPlayer.Backpack)\nc.BinType=Enum.BinType.Hammer\nc=Instance.new('HopperBin',game:GetService('Players').LocalPlayer.Backpack)\nc.BinType=Enum.BinType.Clone\nc=Instance.new('HopperBin',game:GetService('Players').LocalPlayer.Backpack)\nc.BinType=Enum.BinType.Grab");
        }

        // Token: 0x0600000D RID: 13 RVA: 0x00002326 File Offset: 0x00002326
        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It's Destroy exploit - alt delete (Leftalt + mouse)", "Atention");
            api.ExecuteScript("print('Alt delete, script by Morphix For project \"BloxSense V1\"') \nlocal Plr = game:GetService(\"Players\").LocalPlayer\nlocal Mouse = Plr:GetMouse()\nMouse.Button1Down:connect(function()\nif not game:GetService(\"UserInputService\"):IsKeyDown(Enum.KeyCode.LeftAlt) then return end\nif not Mouse.Target then return end\nMouse.Target:Destroy()\nend)");
        }

        // Token: 0x0600000E RID: 14 RVA: 0x0000234A File Offset: 0x0000234A
        private void button13_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("print('SafeField(Force), script by Morphix For project \"BloxSense V1\"') Instance.new('ForceField', game:GetService('Players').LocalPlayer.Character)");
        }

        // Token: 0x0600000F RID: 15 RVA: 0x0000235E File Offset: 0x0000235E
        private void Combat_Paint(object sender, PaintEventArgs e)
        {
        }

        // Token: 0x06000010 RID: 16 RVA: 0x00002361 File Offset: 0x00002361
        private void AntiAims_Paint(object sender, PaintEventArgs e)
        {
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002364 File Offset: 0x00002364
        private void button17_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("while wait(2) do game:GetService('Workspace').TouchTrigger.Donut.Position = game:GetService('Players').LocalPlayer.Character.Head.Position end");
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002378 File Offset: 0x00002378
        private void button18_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftAlt) then return end if not Mouse.Target then return end Mouse.Target:remove() end)");
        }

        // Token: 0x06000013 RID: 19 RVA: 0x0000238C File Offset: 0x0000238C
        private void button19_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("local InfiniteJumpEnabled = true\ngame:GetService('UserInputService').JumpRequest:connect(function()\nif InfiniteJumpEnabled then\ngame:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Jumping')\nend\nend)");
        }

        // Token: 0x06000014 RID: 20 RVA: 0x000023A0 File Offset: 0x000023A0
        private void button20_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("if game:GetService('Workspace').Gravity == 196.2 then/ngame:GetService('Workspace').Gravity = 50\nelse\ngame:GetService('Workspace').Gravity = 196.2\nend");
        }

        // Token: 0x06000015 RID: 21 RVA: 0x000023B4 File Offset: 0x000023B4
        private void button21_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("for i=1,32 do\nwait(.01)\ngame:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1954.95007, 68.0448606, -603.844116) + Vector3.new(1,0,0)\nend");
        }

        // Token: 0x06000016 RID: 22 RVA: 0x000023C8 File Offset: 0x000023C8
        private void button22_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("for i=1,32 do\nwait(.01)\ngame:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(9.92591476, 17.8639755, 786.788147) + Vector3.new(1,0,0)\nend");
        }

        // Token: 0x06000017 RID: 23 RVA: 0x000023DC File Offset: 0x000023DC
        private void button23_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("game:GetService('Players').Name = 'Players' game.Players.LocalPlayer.leaderstats.Money.Value = 1396799499");
        }

        // Token: 0x06000018 RID: 24 RVA: 0x000023F0 File Offset: 0x000023F0
        private void button24_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("dir = 0\ngs = game.GetService\ngs(game,'RunService').RenderStepped:connect(function()\nfor i,v in next,workspace.Vehicles:children() do\nif v.Name ~= 'Heli' then\nif v:FindFirstChild('Engine') then\nlocal bf,cf = v.Engine:FindFirstChild('NewForce'),v:GetPrimaryPartCFrame().lookVector\nif not bf then\nbf = v.Engine:FindFirstChild('BodyForce') or v.Engine:FindFirstChild('VectorForce')\nif bf then\nbf = bf:Clone()\nbf.Parent = v.Engine\nbf.Name = 'NewForce'\nend\nend\nif bf then\nlocal fa = 1\nif v.Name:lower():find('bike') then fa = .3 elseif v.Name:lower():find('bugg') then fa = .5 end\nif v.Seat.PlayerName.Value ~= game:GetService('Players').LocalPlayer.Name then fa = 0 end\nbf.Force = Vector3.new(cf.X*500000*dir*fa,0,cf.Z*500000*dir*fa)\nend\nend\nend\nend\nend)\nval = {\n{Enum.KeyCode.W,1};\n{Enum.KeyCode.S,-1};\n}\nuis = gs(game,'UserInputService')\nchk = function(k)\nfor i,v in next,val do\nif v[1]==k.KeyCode then\nreturn v[2]\nend\nend\nend\nuis.InputBegan:connect(function(k)\ndir = chk(k) or dir\nend)\nuis.InputEnded:connect(function(k)\nif chk(k) == dir then\ndir = 0\nend\nend)");
        }

        // Token: 0x06000019 RID: 25 RVA: 0x00002404 File Offset: 0x00002404
        private void button25_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("game:GetService('Players').LocalPlayer.PlayerGui.MainGui.Nitro.Name = 69696969\ngame:GetService('Players').LocalPlayer.PlayerGui.ProductGui.Nitro:ClearAllChildren()");
        }

        // Token: 0x0600001A RID: 26 RVA: 0x00002418 File Offset: 0x00002418
        private void misc_Paint(object sender, PaintEventArgs e)
        {
        }

        // Token: 0x0600001B RID: 27 RVA: 0x0000241B File Offset: 0x0000241B
        private void button16_Click(object sender, EventArgs e)
        {
            misc.Visible = true;
            Combat.Visible = false;
            AntiAims.Visible = false;
        }

        // Token: 0x0600001C RID: 28 RVA: 0x00002448 File Offset: 0x00002448
        private void button16_Click_1(object sender, EventArgs e)
        {
            misc.Visible = true;
            Combat.Visible = false;
            AntiAims.Visible = false;
            visuals.Visible = false;
            setings1.Visible = false;
            setings2.Visible = false;
        }

        // Token: 0x0600001D RID: 29 RVA: 0x000024A4 File Offset: 0x000024A4
        private void button26_Click(object sender, EventArgs e)
        {
            visuals.Visible = true;
            Combat.Visible = false;
            AntiAims.Visible = false;
            misc.Visible = false;
            setings1.Visible = false;
            setings2.Visible = false;
        }

        // Token: 0x0600001E RID: 30 RVA: 0x00002500 File Offset: 0x00002500
        private void button26_Click_1(object sender, EventArgs e)
        {
            api.ExecuteScript("while true do for i,v in pairs(game.Teams.Police:GetPlayers()) do p=game:GetService('Players') e=Instance.new('BoxHandleAdornment') e.Color3=Color3.new(0,117,250) e.Size=Vector3.new(1,1,1) e.ZIndex=1 e.AlwaysOnTop=true e.Parent=game:GetService('Workspace') e.Adornee=v.Character.Head end wait(5) e:Destroy() end");
        }

        // Token: 0x0600001F RID: 31 RVA: 0x00002514 File Offset: 0x00002514
        private void button27_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("while true do for i,v in pairs(game.Teams.Criminal:GetPlayers()) do p=game:GetService('Players') e=Instance.new('BoxHandleAdornment') e.Color3=Color3.new(255,0,0) e.Size=Vector3.new(1,1,1) e.ZIndex=1 e.AlwaysOnTop=true e.Parent=game:GetService('Workspace') e.Adornee=v.Character.Head end wait(5) e:Destroy() end");
        }

        // Token: 0x06000020 RID: 32 RVA: 0x00002528 File Offset: 0x00002528
        private void button28_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("while wait(.01) do\nif game:GetService(\"Players\").LocalPlayer.PlayerGui:FindFirstChild(\"ScopeGui\") then\ngame:GetService(\"Players\").LocalPlayer.PlayerGui.ScopeGui:remove()\nend\nend");
        }

        // Token: 0x06000021 RID: 33 RVA: 0x0000253C File Offset: 0x0000253C
        private void button12_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3)\na = Instance.new('Part', workspace)\na.Anchored = true\na.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3)\na.CanCollide = false\nfor i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do\nif v.Name == 'Station' then\nfor a, b in pairs(v:GetChildren()) do\nif b:IsA('StringValue') then\nif b.Value == 'Pistol' then\nv.CFrame = CFrame.new(hit)\nend\nend\nend\nend\nend");
        }

        // Token: 0x06000022 RID: 34 RVA: 0x00002550 File Offset: 0x00002550
        private void button11_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3)\na = Instance.new('Part', workspace)\na.Anchored = true\na.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3)\na.CanCollide = false\nfor i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do\nif v.Name == 'Station' then\nfor a, b in pairs(v:GetChildren()) do\nif b:IsA('StringValue') then\nif b.Value == 'Shotgun' then\nv.CFrame = CFrame.new(hit)\nend\nend\nend\nend\nend");
        }

        // Token: 0x06000023 RID: 35 RVA: 0x00002564 File Offset: 0x00002564
        private void button10_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("local part = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) \na = Instance.new('Part', workspace) \na.Anchored = true \na.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) \na.CanCollide = false\nlocal Givers = game:GetService(\"Workspace\").Givers:GetChildren()\nfor i=1, #Givers do\nif Givers[i].Name == \"Guns\" then\nlocal items = Givers[i]:GetChildren()\nfor a=1, #items do\nif items[a].Name == \"Item\" then\nif items[a].Value == \"Sniper\" then\nGivers[i].CFrame = CFrame.new(part)\nend\nend\nend\nend\nend");
        }

        // Token: 0x06000024 RID: 36 RVA: 0x00002578 File Offset: 0x00002578
        private void button9_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("local part = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) \na = Instance.new('Part', workspace) \na.Anchored = true \na.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) \na.CanCollide = false\nlocal Givers = game:GetService(\"Workspace\").Givers:GetChildren()\nfor i=1, #Givers do\nif Givers[i].Name == \"Guns\" then\nlocal items = Givers[i]:GetChildren()\nfor a=1, #items do\nif items[a].Name == \"Item\" then\nif items[a].Value == \"Revolver\" then\nGivers[i].CFrame = CFrame.new(part)\nend\nend\nend\nend\nend");
        }

        // Token: 0x06000025 RID: 37 RVA: 0x0000258C File Offset: 0x0000258C
        private void button8_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("game: GetService('Players').LocalPlayer.TeamValue.Value = 'Police'");
        }

        // Token: 0x06000026 RID: 38 RVA: 0x000025A0 File Offset: 0x000025A0
        private void button7_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("local loc = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart\nlocal list = game:GetService('Teams').Criminal:GetPlayers()\nwait(0.5)\nfor i,v in pairs(list) do\nrepeat wait()\nloc.CFrame = v.Character.HumanoidRootPart.CFrame * CFrame.new(0, 0, 1) until v.Team.Name ~= 'Criminal'\nend");
        }

        // Token: 0x06000027 RID: 39 RVA: 0x000025B4 File Offset: 0x000025B4
        private void button29_Click(object sender, EventArgs e)
        {
            setings1.Visible = true;
            setings2.Visible = true;
            misc.Visible = false;
            visuals.Visible = false;
            Combat.Visible = false;
            AntiAims.Visible = false;
        }

        // Token: 0x06000028 RID: 40 RVA: 0x00002610 File Offset: 0x00002610
        private void button30_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        // Token: 0x06000029 RID: 41 RVA: 0x0000261F File Offset: 0x0000261F
        private void button31_Click(object sender, EventArgs e)
        {
            api.ExecuteScript("wait(1)\ngame.StarterGui:SetCore('SendNotification', {\nTitle = 'Thanks for using!';\nText = 'You have been activated Script Thanks for using our scripts!';\nIcon = 'http://www.roblox.com/asset/?id=145360599';\nDuration = '20';\n})\nlocal BuildABoatForTreasureFarmGUI = Instance.new('ScreenGui')\nlocal MainFrame = Instance.new('Frame')\nlocal Deco = Instance.new('TextLabel')\nlocal SpeedTextBox = Instance.new('TextBox')\nlocal SpeedDeco = Instance.new('TextLabel')\nlocal OnceButton = Instance.new('TextButton')\nlocal AutofarmButton = Instance.new('TextButton')\nlocal AutofarmDeco = Instance.new('TextLabel') \nBuildABoatForTreasureFarmGUI.Name = 'BuildABoatForTreasureFarmGUI'\nBuildABoatForTreasureFarmGUI.Parent = game.CoreGui \nMainFrame.Name = 'MainFrame'\nMainFrame.Parent = BuildABoatForTreasureFarmGUI\nMainFrame.Active = true\nMainFrame.Draggable = true\nMainFrame.BackgroundColor3 = Color3.new(0.196078, 0.196078, 0.196078)\nMainFrame.BorderSizePixel = 0\nMainFrame.Position = UDim2.new(0.25, 0, 0.25, 0)\nMainFrame.Size = UDim2.new(0.15, 0, 0.15, 0) \nDeco.Name = 'Deco'\nDeco.Parent = MainFrame\nDeco.BackgroundColor3 = Color3.new(1, 1, 1)\nDeco.BackgroundTransparency = 0.9\nDeco.BorderSizePixel = 0\nDeco.Size = UDim2.new(1, 0, 0.15, 0)\nDeco.Font = Enum.Font.SourceSansBold\nDeco.Text = 'Build A Boat For Treasure Gold GUI'\nDeco.TextColor3 = Color3.new(1, 1, 1)\nDeco.TextScaled = true\nDeco.TextSize = 14\nDeco.TextWrapped = true\nSpeedTextBox.Name = 'SpeedTextBox'\nSpeedTextBox.Parent = MainFrame\nSpeedTextBox.BackgroundColor3 = Color3.new(1, 1, 1)\nSpeedTextBox.BackgroundTransparency = 0.9\nSpeedTextBox.Position = UDim2.new(0.55, 0, 0.25, 0)\nSpeedTextBox.Size = UDim2.new(0.35, 0, 0.15, 0)\nSpeedTextBox.Font = Enum.Font.SourceSansBold\nSpeedTextBox.Text = '45'\nSpeedTextBox.TextColor3 = Color3.new(1, 1, 1)\nSpeedTextBox.TextScaled = true\nSpeedTextBox.TextSize = 14\nSpeedTextBox.TextWrapped = true \nSpeedDeco.Name = 'SpeedDeco'\nSpeedDeco.Parent = MainFrame\nSpeedDeco.BackgroundColor3 = Color3.new(1, 1, 1)\nSpeedDeco.BackgroundTransparency = 1\nSpeedDeco.BorderSizePixel = 0\nSpeedDeco.Position = UDim2.new(0.1, 0, 0.25, 0)\nSpeedDeco.Size = UDim2.new(0.40, 0, 0.15, 0)\nSpeedDeco.Font = Enum.Font.SourceSansBold\nSpeedDeco.Text = 'Speed'\nSpeedDeco.TextColor3 = Color3.new(1, 1, 1)\nSpeedDeco.TextScaled = true\nSpeedDeco.TextSize = 14\nSpeedDeco.TextWrapped = true \nOnceButton.Name = 'OnceButton'\nOnceButton.Parent = MainFrame\nOnceButton.BackgroundColor3 = Color3.new(0, 0, 0)\nOnceButton.BorderSizePixel = 0\nOnceButton.Position = UDim2.new(0.1, 0, 0.55, 0)\nOnceButton.Size = UDim2.new(0.8, 0, 0.2, 0)\nOnceButton.Font = Enum.Font.SourceSans\nOnceButton.Text = 'Go once'\nOnceButton.TextColor3 = Color3.new(1, 0.85098, 0)\nOnceButton.TextScaled = true\nOnceButton.TextSize = 14\nOnceButton.TextWrapped = true \nAutofarmButton.Name = 'AutofarmButton'\nAutofarmButton.Parent = MainFrame\nAutofarmButton.BackgroundColor3 = Color3.new(0, 0, 0)\nAutofarmButton.BorderSizePixel = 0\nAutofarmButton.Position = UDim2.new(0.55, 0, 0.8, 0)\nAutofarmButton.Size = UDim2.new(0.35, 0, 0.15, 0)\nAutofarmButton.Font = Enum.Font.SourceSans\nAutofarmButton.Text = 'OFF'\nAutofarmButton.TextColor3 = Color3.new(1, 0, 0)\nAutofarmButton.TextScaled = true\nAutofarmButton.TextSize = 14\nAutofarmButton.TextWrapped = true \nAutofarmDeco.Name = 'AutofarmDeco'\nAutofarmDeco.Parent = MainFrame\nAutofarmDeco.BackgroundColor3 = Color3.new(1, 1, 1)\nAutofarmDeco.BackgroundTransparency = 1\nAutofarmDeco.BorderSizePixel = 0\nAutofarmDeco.Position = UDim2.new(0.1, 0, 0.8, 0)\nAutofarmDeco.Size = UDim2.new(0.40, 0, 0.15, 0)\nAutofarmDeco.Font = Enum.Font.SourceSansBold\nAutofarmDeco.Text = 'Autofarm'\nAutofarmDeco.TextColor3 = Color3.new(1, 1, 1)\nAutofarmDeco.TextScaled = true\nAutofarmDeco.TextSize = 14\nAutofarmDeco.TextWrapped = true\nlocal running = false \nspawn(function()\ngame:getService('RunService'):BindToRenderStep('', 0,function()\npcall(function()\nif not game.Players.LocalPlayer.Character:findFirstChildOfClass('Humanoid') then return end\nif not running == true then return end\ngame.Players.LocalPlayer.Character:findFirstChildOfClass('Humanoid'):ChangeState(11)\nend)\nend)\nend)\nfunction doTheThing()\nif running == false then\nlocal checks = workspace.BoatTerrains:getDescendants()\nfor i=1,#checks do\nrunning = true\nif checks[i].Name == 'DarknessPart' or checks[i].Name == 'GatePart' then\nif game.Players.LocalPlayer.Character:FindFirstChild('Humanoid') then\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = checks[i].CFrame\nend\nwait(18.9/tonumber(SpeedTextBox.Text)) \nend\nend\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = workspace.GoldenChest.Collider.CFrame\nrepeat\nif game.Players.LocalPlayer.Character:FindFirstChild('Humanoid') then\ngame.Players.LocalPlayer.Character.Humanoid.Jump = true\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = workspace.GoldenChest.Collider.CFrame\nend\nwait()\nuntil not game.Players.LocalPlayer.Character:FindFirstChild('Humanoid')\nrunning = false\nend\nend \nOnceButton.MouseButton1Down:connect(function()\ndoTheThing()\nend)\nlocal autofarming = false\nAutofarmButton.MouseButton1Down:connect(function()\nif AutofarmButton.Text == 'ON' then\nAutofarmButton.Text = 'OFF'\nAutofarmButton.TextColor3 = Color3.fromRGB(255,0,0)\nautofarming = false\nrunning = false\nelse\nAutofarmButton.Text = 'ON'\nAutofarmButton.TextColor3 = Color3.fromRGB(0,255,0)\nautofarming = true\nend\nend) \nspawn(function()\nwhile true do\nwait(0.1)\nif autofarming == true then\ndoTheThing()\nend\nend\nend)");
        }

        // Token: 0x0600002A RID: 42 RVA: 0x00002633 File Offset: 0x00002633
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        // Token: 0x0600002B RID: 43 RVA: 0x00002638 File Offset: 0x00002638
        private void button32_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.ShowDialog();
        }

        // Token: 0x0600002C RID: 44 RVA: 0x00002654 File Offset: 0x00002654
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string path;
            for (; ; )
            {
                comboBox2.Items.Clear();
                path = Application.StartupPath + "\\lua\\";
                bool flag = Directory.Exists(path);
                if (flag)
                {
                    break;
                }
                Directory.CreateDirectory(path);
            }
            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                comboBox2.Items.Add(files);
            }
        }

        // Token: 0x0600002D RID: 45 RVA: 0x000026CC File Offset: 0x000026CC
        private void button33_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;
            string text = comboBox2.SelectedItem.ToString();
            MessageBox.Show(text);
        }

        // Token: 0x04000001 RID: 1
        private bool logined = false;

        // Token: 0x04000002 RID: 2
        private Module api = new Module();

        // Token: 0x04000003 RID: 3
        private Point MouseHook;
    }
}
