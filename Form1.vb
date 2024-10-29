Public Class Form1

    Dim breachinfo As String = "Breach, the bionic Swede, fires powerful, targeted kinetic blasts to aggressively clear a path through enemy ground. The damage and disruption he inflicts ensures no fight is ever fair."
    Dim aftershock As String = "EQUIP a fusion charge. FIRE the charge to set a slow-acting burst through the wall. The burst does heavy damage to anyone caught in its area."
    Dim flashpoint As String = "EQUIP a blinding charge. FIRE the charge to set a fast-acting burst through the wall. The charge detonates to Blind all players looking at it."
    Dim faultline As String = "EQUIP a seismic blast. HOLD FIRE to increase the distance. RELEASE to set off the quake, Concussing all players in its zone and in a line up to the zone."
    Dim rollingthunder As String = "EQUIP a Seismic Charge. FIRE to send a cascading quake through all terrain in a large cone. The quake Concusses and knocks up anyone caught in it."

    'PANEL AGENTS'
    Private Sub btnInitiator_Click(sender As Object, e As EventArgs) Handles btnInitiator.Click
        pnlInitiator.Visible = True
        pnlDuelist.Visible = False
        pnlSentinel.Visible = False
        pnlController.Visible = False
        pnlAgents.Visible = False
    End Sub

    Private Sub btnDuelist_Click(sender As Object, e As EventArgs) Handles btnDuelist.Click
        pnlInitiator.Visible = False
        pnlDuelist.Visible = True
        pnlSentinel.Visible = False
        pnlController.Visible = False
        pnlAgents.Visible = False
    End Sub

    Private Sub btnSentinel_Click(sender As Object, e As EventArgs) Handles btnSentinel.Click
        pnlInitiator.Visible = False
        pnlDuelist.Visible = False
        pnlSentinel.Visible = True
        pnlController.Visible = False
        pnlAgents.Visible = False
    End Sub

    Private Sub btnController_Click(sender As Object, e As EventArgs) Handles btnController.Click
        pnlInitiator.Visible = False
        pnlDuelist.Visible = False
        pnlSentinel.Visible = False
        pnlController.Visible = True
        pnlAgents.Visible = False
    End Sub

    'BREACH'
    Private Sub btnBreach_Click(sender As Object, e As EventArgs) Handles btnBreach.Click
        lblInfo.Text = breachinfo
        btnBreachinfo.Visible = True
        btnAgentInfo.Visible = True
        btnAftershock.Visible = True
        btnFlashpoint.Visible = True
        btnFaultline.Visible = True
        btnRollingThunder.Visible = True

        btnSkill1.Visible = False
        btnSkill2.Visible = False
        btnSkill3.Visible = False
        btnSkill4.Visible = False
        btnAgentInfo.Visible = False

        'neon'
        btnNeoninfo.Visible = False
        btnFastLane.Visible = False
        btnRelayBolt.Visible = False
        btnHighGear.Visible = False
        btnOverdrive.Visible = False

        'astra'
        btnAstrainfo.Visible = False
        btnGravityWell.Visible = False
        btnNovaPulse.Visible = False
        btnNebulaDissipate.Visible = False
        btnCosmicDivide.Visible = False

        'fade'
        btnFadeinfo.Visible = False
        btnProwler.Visible = False
        btnSeize.Visible = False
        btnHaunt.Visible = False
        btnNightfall.Visible = False
    End Sub

    Private Sub btnAftershock_Click(sender As Object, e As EventArgs) Handles btnAftershock.Click
        lblInfo.Text = aftershock
    End Sub

    Private Sub btnFlashpoint_Click(sender As Object, e As EventArgs) Handles btnFlashpoint.Click
        lblInfo.Text = flashpoint
    End Sub

    Private Sub btnFaultline_Click(sender As Object, e As EventArgs) Handles btnFaultline.Click
        lblInfo.Text = faultline
    End Sub

    Private Sub btnRollingThunder_Click(sender As Object, e As EventArgs) Handles btnRollingThunder.Click
        lblInfo.Text = rollingthunder
    End Sub
    Private Sub btnBreachinfo_Click(sender As Object, e As EventArgs) Handles btnBreachinfo.Click
        lblInfo.Text = breachinfo
    End Sub

    'NEON'
    Dim neoninfo As String = "Filipino Agent, Neon, surges forward at shocking speeds, discharging bursts of bioelectric radiance as fast as her body generates it. She races ahead to catch enemies off guard, then strikes them down quicker than lightning."
    Dim fastlane As String = "FIRE two energy lines forward on the ground that extend a short distance or until they hit a surface. The lines rise into walls of static electricity that block vision."
    Dim relaybolt As String = "INSTANTLY throw an energy bolt that bounces once. Upon hitting each surface, the bolt electrifies the ground below with a Concussive blast."
    Dim highgear As String = "INSTANTLY channel Neon's power for Increased Speed. When charged, ALT FIRE to trigger an electric slide. Slide charge resets every two kills."
    Dim overdrive As String = "Unleash Neon's full power and speed for a short duration. FIRE to channel the power into a deadly lightning beam with high movement accuracy."
    Private Sub btnNeon_Click(sender As Object, e As EventArgs) Handles btnNeon.Click
        lblInfo.Text = neoninfo
        btnNeoninfo.Visible = True
        btnAgentInfo.Visible = True
        btnFastLane.Visible = True
        btnRelayBolt.Visible = True
        btnHighGear.Visible = True
        btnOverdrive.Visible = True

        btnSkill1.Visible = False
        btnSkill2.Visible = False
        btnSkill3.Visible = False
        btnSkill4.Visible = False
        btnAgentInfo.Visible = False

        'breach'
        btnBreachinfo.Visible = False
        btnAftershock.Visible = False
        btnFlashpoint.Visible = False
        btnFaultline.Visible = False
        btnRollingThunder.Visible = False

        'astra'
        btnAstrainfo.Visible = False
        btnGravityWell.Visible = False
        btnNovaPulse.Visible = False
        btnNebulaDissipate.Visible = False
        btnCosmicDivide.Visible = False

        'fade'
        btnFadeinfo.Visible = False
        btnProwler.Visible = False
        btnSeize.Visible = False
        btnHaunt.Visible = False
        btnNightfall.Visible = False

    End Sub

    Private Sub btnNeoninfo_Click(sender As Object, e As EventArgs) Handles btnNeoninfo.Click
        lblInfo.Text = neoninfo
    End Sub

    Private Sub btnFastLane_Click(sender As Object, e As EventArgs) Handles btnFastLane.Click
        lblInfo.Text = fastlane
    End Sub

    Private Sub btnRelayBolt_Click(sender As Object, e As EventArgs) Handles btnRelayBolt.Click
        lblInfo.Text = relaybolt
    End Sub

    Private Sub btnHighGear_Click(sender As Object, e As EventArgs) Handles btnHighGear.Click
        lblInfo.Text = highgear
    End Sub

    Private Sub btnOverdrive_Click(sender As Object, e As EventArgs) Handles btnOverdrive.Click
        lblInfo.Text = overdrive
    End Sub

    'ASTRA'
    Dim astrainfo As String = "Ghanaian Agent Astra harnesses the energies of the cosmos to reshape battlefields to her whim. With full command of her astral form and a talent for deep strategic foresight, she’s always eons ahead of her enemy’s next move."
    Dim gravitywell As String = "ACTIVATE a Star to form a Gravity Well. Players in the area are pulled toward the center before it explodes, making all players still trapped inside Vulnerable."
    Dim novapulse As String = "ACTIVATE a Star to detonate a Nova Pulse. The Nova Pulse charges briefly then strikes, Concussing all players in its area."
    Dim nebula As String = "ACTIVATE a Star to transform it into a Nebula (smoke).
USE a Star to Dissipate it, returning the Star to be placed in a new location after a delay.
Dissipate briefly forms a fake Nebula at the Star's location before returning."
    Dim cosmicdivide As String = "When Cosmic Divide is charged, use ALT FIRE in Astral Form to begin aiming it, then FIRE to select two locations. An infinite Cosmic Divide connects the two points you select. Cosmic Divide blocks bullets and sound."

    Private Sub btnAstra_Click(sender As Object, e As EventArgs) Handles btnAstra.Click
        lblInfo.Text = astrainfo
        btnAstrainfo.Visible = True
        btnGravityWell.Visible = True
        btnNovaPulse.Visible = True
        btnNebulaDissipate.Visible = True
        btnCosmicDivide.Visible = True

        btnSkill1.Visible = False
        btnSkill2.Visible = False
        btnSkill3.Visible = False
        btnSkill4.Visible = False
        btnAgentInfo.Visible = False

        'neon'
        btnNeoninfo.Visible = False
        btnFastLane.Visible = False
        btnRelayBolt.Visible = False
        btnHighGear.Visible = False
        btnOverdrive.Visible = False

        'breach'
        btnBreachinfo.Visible = False
        btnAftershock.Visible = False
        btnFlashpoint.Visible = False
        btnFaultline.Visible = False
        btnRollingThunder.Visible = False

        'fade'
        btnFadeinfo.Visible = False
        btnProwler.Visible = False
        btnSeize.Visible = False
        btnHaunt.Visible = False
        btnNightfall.Visible = False
    End Sub

    Private Sub btnAstrainfo_Click(sender As Object, e As EventArgs) Handles btnAstrainfo.Click
        lblInfo.Text = astrainfo
    End Sub
    Private Sub btnGravityWell_Click(sender As Object, e As EventArgs) Handles btnGravityWell.Click
        lblInfo.Text = gravitywell
    End Sub
    Private Sub btnNovaPulse_Click(sender As Object, e As EventArgs) Handles btnNovaPulse.Click
        lblInfo.Text = novapulse
    End Sub

    Private Sub btnNebulaDissipate_Click(sender As Object, e As EventArgs) Handles btnNebulaDissipate.Click
        lblInfo.Text = nebula
    End Sub

    Private Sub btnCosmicDivide_Click(sender As Object, e As EventArgs) Handles btnCosmicDivide.Click
        lblInfo.Text = cosmicdivide
    End Sub

    'FADE'
    Dim fadeinfo As String = "Turkish bounty hunter Fade unleashes the power of raw nightmare to seize enemy secrets. Attuned with terror itself, she hunts down targets and reveals their deepest fears - before crushing them in the dark."
    Dim prowler As String = "EQUIP a prowler. FIRE to send the prowler forward. HOLD FIRE to steer the prowler towards your crosshair. The prowler will chase down the first enemy or terror trail it sees, and nearsight the enemy on impact."
    Dim seize As String = "EQUIP a knot of raw fear. FIRE to throw. The knot drops down after a set time. RE-USE to drop the knot early. The knot ruptures on impact, holding nearby enemies in place. Held enemies are Deafened, and Decayed."
    Dim haunt As String = "EQUIP a haunting watcher. FIRE to throw. The watcher drops down after a set time. RE-USE to drop the watcher early. The watcher lashes out on impact, Revealing enemies in its line of sight and creating terror trails to them. Enemies can destroy the watcher."
    Dim nightfall As String = "EQUIP the power of nightmare itself. FIRE to unleash a wave of unstoppable nightmare energy. Enemies caught in the wave are Marked by terror trails, Deafened, and Decayed."

    Private Sub btnFade_Click(sender As Object, e As EventArgs) Handles btnFade.Click
        lblInfo.Text = fadeinfo
        btnFadeinfo.Visible = True
        btnProwler.Visible = True
        btnSeize.Visible = True
        btnHaunt.Visible = True
        btnNightfall.Visible = True

        btnSkill1.Visible = False
        btnSkill2.Visible = False
        btnSkill3.Visible = False
        btnSkill4.Visible = False
        btnAgentInfo.Visible = False

        'neon'
        btnNeoninfo.Visible = False
        btnFastLane.Visible = False
        btnRelayBolt.Visible = False
        btnHighGear.Visible = False
        btnOverdrive.Visible = False

        'breach'
        btnBreachinfo.Visible = False
        btnAftershock.Visible = False
        btnFlashpoint.Visible = False
        btnFaultline.Visible = False
        btnRollingThunder.Visible = False

        'astra'
        btnAstrainfo.Visible = False
        btnGravityWell.Visible = False
        btnNovaPulse.Visible = False
        btnNebulaDissipate.Visible = False
        btnCosmicDivide.Visible = False

        'raze'
        btnRazeinfo.Visible = True
        btnBoombot.Visible = True
        btnBlastpack.Visible = True
        btnPaintshells.Visible = True
        btnShowstopper.Visible = True

    End Sub

    Private Sub btnFadeinfo_Click(sender As Object, e As EventArgs) Handles btnFadeinfo.Click
        lblInfo.Text = fadeinfo
    End Sub

    Private Sub btnProwler_Click(sender As Object, e As EventArgs) Handles btnProwler.Click
        lblInfo.Text = prowler
    End Sub

    Private Sub btnSeize_Click(sender As Object, e As EventArgs) Handles btnSeize.Click
        lblInfo.Text = seize
    End Sub

    Private Sub btnHaunt_Click(sender As Object, e As EventArgs) Handles btnHaunt.Click
        lblInfo.Text = haunt
    End Sub

    Private Sub btnNightfall_Click(sender As Object, e As EventArgs) Handles btnNightfall.Click
        lblInfo.Text = nightfall
    End Sub

    'RAZE'
    Dim razeinfo As String = "Raze explodes out of Brazil with her big personality and big guns. With her blunt-force-trauma playstyle, she excels at flushing entrenched enemies and clearing tight spaces with a generous dose of boom."
    Dim boombot As String = "EQUIP a Boom Bot. FIRE will deploy the bot, causing it to travel in a straight line on the ground, bouncing off walls. The Boom Bot will lock on to any enemies in its frontal cone and chase them, exploding for heavy damage if it reaches them."
    Dim blastpack As String = "INSTANTLY throw a Blast Pack that will stick to surfaces. RE-USE the ability after deployment to detonate, damaging and moving anything hit.INSTANTLY throw a Blast Pack that will stick to surfaces. RE-USE the ability after deployment to detonate, damaging and moving anything hit."
    Dim paintshells As String = "EQUIP a cluster grenade. FIRE to throw the grenade, which does damage and creates sub-munitions, each doing damage to anyone in their range. ALT FIRE to lob. Paint Shells charge resets every two kills."
    Dim showstopper As String = "EQUIP a rocket launcher. FIRE to shoot a rocket that does massive area damage on contact with anything."

    Private Sub btnRaze_Click(sender As Object, e As EventArgs) Handles btnRaze.Click
        lblInfo.Text = razeinfo
        btnRazeinfo.Visible = True
        btnBoombot.Visible = True
        btnBlastpack.Visible = True
        btnPaintshells.Visible = True
        btnShowstopper.Visible = True

        'fade'
        btnFadeinfo.Visible = False
        btnProwler.Visible = False
        btnSeize.Visible = False
        btnHaunt.Visible = False
        btnNightfall.Visible = False

        btnSkill1.Visible = False
        btnSkill2.Visible = False
        btnSkill3.Visible = False
        btnSkill4.Visible = False
        btnAgentInfo.Visible = False

        'neon'
        btnNeoninfo.Visible = False
        btnFastLane.Visible = False
        btnRelayBolt.Visible = False
        btnHighGear.Visible = False
        btnOverdrive.Visible = False

        'breach'
        btnBreachinfo.Visible = False
        btnAftershock.Visible = False
        btnFlashpoint.Visible = False
        btnFaultline.Visible = False
        btnRollingThunder.Visible = False

        'astra'
        btnAstrainfo.Visible = False
        btnGravityWell.Visible = False
        btnNovaPulse.Visible = False
        btnNebulaDissipate.Visible = False
        btnCosmicDivide.Visible = False
    End Sub
    Private Sub btnRazeinfo_Click(sender As Object, e As EventArgs) Handles btnRazeinfo.Click
        lblInfo.Text = razeinfo

    End Sub

    Private Sub btnBoombot_Click(sender As Object, e As EventArgs) Handles btnBoombot.Click
        lblInfo.Text = boombot
    End Sub

    Private Sub btnBlastpack_Click(sender As Object, e As EventArgs) Handles btnBlastpack.Click
        lblInfo.Text = blastpack
    End Sub

    Private Sub btnPaintshells_Click(sender As Object, e As EventArgs) Handles btnPaintshells.Click
        lblInfo.Text = paintshells
    End Sub

    Private Sub btnShowstopper_Click(sender As Object, e As EventArgs) Handles btnShowstopper.Click
        lblInfo.Text = showstopper
    End Sub

    'skye' 
    Dim skyeinfo As String
    Private Sub btnSkye_Click(sender As Object, e As EventArgs) Handles btnSkye.Click

    End Sub
End Class
