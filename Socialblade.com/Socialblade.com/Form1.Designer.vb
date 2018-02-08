<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cover = New System.Windows.Forms.PictureBox()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.upload = New System.Windows.Forms.Label()
        Me.subs = New System.Windows.Forms.Label()
        Me.count = New System.Windows.Forms.Label()
        Me.country = New System.Windows.Forms.Label()
        Me.type = New System.Windows.Forms.Label()
        Me.created = New System.Windows.Forms.Label()
        Me.pcountry = New System.Windows.Forms.PictureBox()
        Me.CountryL = New System.Windows.Forms.ImageList(Me.components)
        Me.user = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grade = New System.Windows.Forms.Label()
        Me.subsrank = New System.Windows.Forms.Label()
        Me.videorank = New System.Windows.Forms.Label()
        Me.sbrank = New System.Windows.Forms.Label()
        CType(Me.cover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcountry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(329, 6)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(186, 22)
        Me.TXT_ID.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(521, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "GET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Channel ID"
        '
        'cover
        '
        Me.cover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cover.Location = New System.Drawing.Point(3, 39)
        Me.cover.Name = "cover"
        Me.cover.Size = New System.Drawing.Size(596, 132)
        Me.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cover.TabIndex = 5
        Me.cover.TabStop = False
        '
        'photo
        '
        Me.photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.photo.Location = New System.Drawing.Point(12, 72)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(94, 93)
        Me.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.photo.TabIndex = 6
        Me.photo.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(471, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "USER CREATED"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(367, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "CHANNEL TYPE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(295, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "COUNTRY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "VIDEO VIEWS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SUBSCRIBERS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "UPLOADS"
        '
        'upload
        '
        Me.upload.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upload.Location = New System.Drawing.Point(38, 192)
        Me.upload.Name = "upload"
        Me.upload.Size = New System.Drawing.Size(62, 19)
        Me.upload.TabIndex = 14
        Me.upload.Text = "--"
        Me.upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subs
        '
        Me.subs.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subs.Location = New System.Drawing.Point(109, 192)
        Me.subs.Name = "subs"
        Me.subs.Size = New System.Drawing.Size(85, 19)
        Me.subs.TabIndex = 15
        Me.subs.Text = "--"
        Me.subs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'count
        '
        Me.count.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count.Location = New System.Drawing.Point(203, 192)
        Me.count.Name = "count"
        Me.count.Size = New System.Drawing.Size(86, 19)
        Me.count.TabIndex = 16
        Me.count.Text = "--"
        Me.count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'country
        '
        Me.country.AutoSize = True
        Me.country.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.country.Location = New System.Drawing.Point(298, 192)
        Me.country.Name = "country"
        Me.country.Size = New System.Drawing.Size(19, 19)
        Me.country.TabIndex = 17
        Me.country.Text = "--"
        Me.country.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'type
        '
        Me.type.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type.Location = New System.Drawing.Point(370, 192)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(95, 19)
        Me.type.TabIndex = 18
        Me.type.Text = "--"
        Me.type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'created
        '
        Me.created.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.created.Location = New System.Drawing.Point(474, 192)
        Me.created.Name = "created"
        Me.created.Size = New System.Drawing.Size(122, 19)
        Me.created.TabIndex = 19
        Me.created.Text = "--"
        Me.created.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcountry
        '
        Me.pcountry.Location = New System.Drawing.Point(329, 192)
        Me.pcountry.Name = "pcountry"
        Me.pcountry.Size = New System.Drawing.Size(31, 19)
        Me.pcountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcountry.TabIndex = 20
        Me.pcountry.TabStop = False
        '
        'CountryL
        '
        Me.CountryL.ImageStream = CType(resources.GetObject("CountryL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.CountryL.TransparentColor = System.Drawing.Color.Transparent
        Me.CountryL.Images.SetKeyName(0, "_African Union(OAS).png")
        Me.CountryL.Images.SetKeyName(1, "_Arab League.png")
        Me.CountryL.Images.SetKeyName(2, "_ASEAN.png")
        Me.CountryL.Images.SetKeyName(3, "_CARICOM.png")
        Me.CountryL.Images.SetKeyName(4, "_CIS.png")
        Me.CountryL.Images.SetKeyName(5, "_Commonwealth.png")
        Me.CountryL.Images.SetKeyName(6, "_England.png")
        Me.CountryL.Images.SetKeyName(7, "_European Union.png")
        Me.CountryL.Images.SetKeyName(8, "_Islamic Conference.png")
        Me.CountryL.Images.SetKeyName(9, "_Kosovo.png")
        Me.CountryL.Images.SetKeyName(10, "_NATO.png")
        Me.CountryL.Images.SetKeyName(11, "_Northern Cyprus.png")
        Me.CountryL.Images.SetKeyName(12, "_Northern Ireland.png")
        Me.CountryL.Images.SetKeyName(13, "_Olimpic Movement.png")
        Me.CountryL.Images.SetKeyName(14, "_OPEC.png")
        Me.CountryL.Images.SetKeyName(15, "_Red Cross.png")
        Me.CountryL.Images.SetKeyName(16, "_Scotland.png")
        Me.CountryL.Images.SetKeyName(17, "_Somaliland.png")
        Me.CountryL.Images.SetKeyName(18, "_United Nations.png")
        Me.CountryL.Images.SetKeyName(19, "_Wales.png")
        Me.CountryL.Images.SetKeyName(20, "ad.png")
        Me.CountryL.Images.SetKeyName(21, "ae.png")
        Me.CountryL.Images.SetKeyName(22, "af.png")
        Me.CountryL.Images.SetKeyName(23, "ag.png")
        Me.CountryL.Images.SetKeyName(24, "ai.png")
        Me.CountryL.Images.SetKeyName(25, "al.png")
        Me.CountryL.Images.SetKeyName(26, "am.png")
        Me.CountryL.Images.SetKeyName(27, "an.png")
        Me.CountryL.Images.SetKeyName(28, "ao.png")
        Me.CountryL.Images.SetKeyName(29, "aq.png")
        Me.CountryL.Images.SetKeyName(30, "ar.png")
        Me.CountryL.Images.SetKeyName(31, "as.png")
        Me.CountryL.Images.SetKeyName(32, "at.png")
        Me.CountryL.Images.SetKeyName(33, "au.png")
        Me.CountryL.Images.SetKeyName(34, "aw.png")
        Me.CountryL.Images.SetKeyName(35, "az.png")
        Me.CountryL.Images.SetKeyName(36, "ba.png")
        Me.CountryL.Images.SetKeyName(37, "bb.png")
        Me.CountryL.Images.SetKeyName(38, "bd.png")
        Me.CountryL.Images.SetKeyName(39, "be.png")
        Me.CountryL.Images.SetKeyName(40, "bf.png")
        Me.CountryL.Images.SetKeyName(41, "bg.png")
        Me.CountryL.Images.SetKeyName(42, "bh.png")
        Me.CountryL.Images.SetKeyName(43, "bi.png")
        Me.CountryL.Images.SetKeyName(44, "bj.png")
        Me.CountryL.Images.SetKeyName(45, "bm.png")
        Me.CountryL.Images.SetKeyName(46, "bn.png")
        Me.CountryL.Images.SetKeyName(47, "bo.png")
        Me.CountryL.Images.SetKeyName(48, "br.png")
        Me.CountryL.Images.SetKeyName(49, "bs.png")
        Me.CountryL.Images.SetKeyName(50, "bt.png")
        Me.CountryL.Images.SetKeyName(51, "bw.png")
        Me.CountryL.Images.SetKeyName(52, "by.png")
        Me.CountryL.Images.SetKeyName(53, "bz.png")
        Me.CountryL.Images.SetKeyName(54, "ca.png")
        Me.CountryL.Images.SetKeyName(55, "cd.png")
        Me.CountryL.Images.SetKeyName(56, "cf.png")
        Me.CountryL.Images.SetKeyName(57, "cg.png")
        Me.CountryL.Images.SetKeyName(58, "ch.png")
        Me.CountryL.Images.SetKeyName(59, "ci.png")
        Me.CountryL.Images.SetKeyName(60, "ck.png")
        Me.CountryL.Images.SetKeyName(61, "cl.png")
        Me.CountryL.Images.SetKeyName(62, "cm.png")
        Me.CountryL.Images.SetKeyName(63, "cn.png")
        Me.CountryL.Images.SetKeyName(64, "co.png")
        Me.CountryL.Images.SetKeyName(65, "cr.png")
        Me.CountryL.Images.SetKeyName(66, "cu.png")
        Me.CountryL.Images.SetKeyName(67, "cv.png")
        Me.CountryL.Images.SetKeyName(68, "cy.png")
        Me.CountryL.Images.SetKeyName(69, "cz.png")
        Me.CountryL.Images.SetKeyName(70, "de.png")
        Me.CountryL.Images.SetKeyName(71, "dj.png")
        Me.CountryL.Images.SetKeyName(72, "dk.png")
        Me.CountryL.Images.SetKeyName(73, "dm.png")
        Me.CountryL.Images.SetKeyName(74, "do.png")
        Me.CountryL.Images.SetKeyName(75, "dz.png")
        Me.CountryL.Images.SetKeyName(76, "ec.png")
        Me.CountryL.Images.SetKeyName(77, "ee.png")
        Me.CountryL.Images.SetKeyName(78, "eg.png")
        Me.CountryL.Images.SetKeyName(79, "eh.png")
        Me.CountryL.Images.SetKeyName(80, "er.png")
        Me.CountryL.Images.SetKeyName(81, "es.png")
        Me.CountryL.Images.SetKeyName(82, "et.png")
        Me.CountryL.Images.SetKeyName(83, "fi.png")
        Me.CountryL.Images.SetKeyName(84, "fj.png")
        Me.CountryL.Images.SetKeyName(85, "fm.png")
        Me.CountryL.Images.SetKeyName(86, "fo.png")
        Me.CountryL.Images.SetKeyName(87, "fr.png")
        Me.CountryL.Images.SetKeyName(88, "ga.png")
        Me.CountryL.Images.SetKeyName(89, "gb.png")
        Me.CountryL.Images.SetKeyName(90, "gd.png")
        Me.CountryL.Images.SetKeyName(91, "ge.png")
        Me.CountryL.Images.SetKeyName(92, "gg.png")
        Me.CountryL.Images.SetKeyName(93, "gh.png")
        Me.CountryL.Images.SetKeyName(94, "gi.png")
        Me.CountryL.Images.SetKeyName(95, "gl.png")
        Me.CountryL.Images.SetKeyName(96, "gm.png")
        Me.CountryL.Images.SetKeyName(97, "gn.png")
        Me.CountryL.Images.SetKeyName(98, "gp.png")
        Me.CountryL.Images.SetKeyName(99, "gq.png")
        Me.CountryL.Images.SetKeyName(100, "gr.png")
        Me.CountryL.Images.SetKeyName(101, "gt.png")
        Me.CountryL.Images.SetKeyName(102, "gu.png")
        Me.CountryL.Images.SetKeyName(103, "gw.png")
        Me.CountryL.Images.SetKeyName(104, "gy.png")
        Me.CountryL.Images.SetKeyName(105, "hk.png")
        Me.CountryL.Images.SetKeyName(106, "hn.png")
        Me.CountryL.Images.SetKeyName(107, "hr.png")
        Me.CountryL.Images.SetKeyName(108, "ht.png")
        Me.CountryL.Images.SetKeyName(109, "hu.png")
        Me.CountryL.Images.SetKeyName(110, "id.png")
        Me.CountryL.Images.SetKeyName(111, "ie.png")
        Me.CountryL.Images.SetKeyName(112, "il.png")
        Me.CountryL.Images.SetKeyName(113, "im.png")
        Me.CountryL.Images.SetKeyName(114, "in.png")
        Me.CountryL.Images.SetKeyName(115, "iq.png")
        Me.CountryL.Images.SetKeyName(116, "ir.png")
        Me.CountryL.Images.SetKeyName(117, "is.png")
        Me.CountryL.Images.SetKeyName(118, "it.png")
        Me.CountryL.Images.SetKeyName(119, "je.png")
        Me.CountryL.Images.SetKeyName(120, "jm.png")
        Me.CountryL.Images.SetKeyName(121, "jo.png")
        Me.CountryL.Images.SetKeyName(122, "jp.png")
        Me.CountryL.Images.SetKeyName(123, "ke.png")
        Me.CountryL.Images.SetKeyName(124, "kg.png")
        Me.CountryL.Images.SetKeyName(125, "kh.png")
        Me.CountryL.Images.SetKeyName(126, "ki.png")
        Me.CountryL.Images.SetKeyName(127, "km.png")
        Me.CountryL.Images.SetKeyName(128, "kn.png")
        Me.CountryL.Images.SetKeyName(129, "kp.png")
        Me.CountryL.Images.SetKeyName(130, "kr.png")
        Me.CountryL.Images.SetKeyName(131, "kw.png")
        Me.CountryL.Images.SetKeyName(132, "ky.png")
        Me.CountryL.Images.SetKeyName(133, "kz.png")
        Me.CountryL.Images.SetKeyName(134, "la.png")
        Me.CountryL.Images.SetKeyName(135, "lb.png")
        Me.CountryL.Images.SetKeyName(136, "lc.png")
        Me.CountryL.Images.SetKeyName(137, "li.png")
        Me.CountryL.Images.SetKeyName(138, "lk.png")
        Me.CountryL.Images.SetKeyName(139, "lr.png")
        Me.CountryL.Images.SetKeyName(140, "ls.png")
        Me.CountryL.Images.SetKeyName(141, "lt.png")
        Me.CountryL.Images.SetKeyName(142, "lu.png")
        Me.CountryL.Images.SetKeyName(143, "lv.png")
        Me.CountryL.Images.SetKeyName(144, "ly.png")
        Me.CountryL.Images.SetKeyName(145, "ma.png")
        Me.CountryL.Images.SetKeyName(146, "mc.png")
        Me.CountryL.Images.SetKeyName(147, "md.png")
        Me.CountryL.Images.SetKeyName(148, "me.png")
        Me.CountryL.Images.SetKeyName(149, "mg.png")
        Me.CountryL.Images.SetKeyName(150, "mh.png")
        Me.CountryL.Images.SetKeyName(151, "mk.png")
        Me.CountryL.Images.SetKeyName(152, "ml.png")
        Me.CountryL.Images.SetKeyName(153, "mm.png")
        Me.CountryL.Images.SetKeyName(154, "mn.png")
        Me.CountryL.Images.SetKeyName(155, "mo.png")
        Me.CountryL.Images.SetKeyName(156, "mq.png")
        Me.CountryL.Images.SetKeyName(157, "mr.png")
        Me.CountryL.Images.SetKeyName(158, "ms.png")
        Me.CountryL.Images.SetKeyName(159, "mt.png")
        Me.CountryL.Images.SetKeyName(160, "mu.png")
        Me.CountryL.Images.SetKeyName(161, "mv.png")
        Me.CountryL.Images.SetKeyName(162, "mw.png")
        Me.CountryL.Images.SetKeyName(163, "mx.png")
        Me.CountryL.Images.SetKeyName(164, "my.png")
        Me.CountryL.Images.SetKeyName(165, "mz.png")
        Me.CountryL.Images.SetKeyName(166, "na.png")
        Me.CountryL.Images.SetKeyName(167, "nc.png")
        Me.CountryL.Images.SetKeyName(168, "ne.png")
        Me.CountryL.Images.SetKeyName(169, "ng.png")
        Me.CountryL.Images.SetKeyName(170, "ni.png")
        Me.CountryL.Images.SetKeyName(171, "nl.png")
        Me.CountryL.Images.SetKeyName(172, "no.png")
        Me.CountryL.Images.SetKeyName(173, "np.png")
        Me.CountryL.Images.SetKeyName(174, "nr.png")
        Me.CountryL.Images.SetKeyName(175, "nz.png")
        Me.CountryL.Images.SetKeyName(176, "om.png")
        Me.CountryL.Images.SetKeyName(177, "pa.png")
        Me.CountryL.Images.SetKeyName(178, "pe.png")
        Me.CountryL.Images.SetKeyName(179, "pf.png")
        Me.CountryL.Images.SetKeyName(180, "pg.png")
        Me.CountryL.Images.SetKeyName(181, "ph.png")
        Me.CountryL.Images.SetKeyName(182, "pk.png")
        Me.CountryL.Images.SetKeyName(183, "pl.png")
        Me.CountryL.Images.SetKeyName(184, "pr.png")
        Me.CountryL.Images.SetKeyName(185, "ps.png")
        Me.CountryL.Images.SetKeyName(186, "pt.png")
        Me.CountryL.Images.SetKeyName(187, "pw.png")
        Me.CountryL.Images.SetKeyName(188, "py.png")
        Me.CountryL.Images.SetKeyName(189, "qa.png")
        Me.CountryL.Images.SetKeyName(190, "re.png")
        Me.CountryL.Images.SetKeyName(191, "ro.png")
        Me.CountryL.Images.SetKeyName(192, "rs.png")
        Me.CountryL.Images.SetKeyName(193, "ru.png")
        Me.CountryL.Images.SetKeyName(194, "rw.png")
        Me.CountryL.Images.SetKeyName(195, "sa.png")
        Me.CountryL.Images.SetKeyName(196, "sb.png")
        Me.CountryL.Images.SetKeyName(197, "sc.png")
        Me.CountryL.Images.SetKeyName(198, "sd.png")
        Me.CountryL.Images.SetKeyName(199, "se.png")
        Me.CountryL.Images.SetKeyName(200, "sg.png")
        Me.CountryL.Images.SetKeyName(201, "si.png")
        Me.CountryL.Images.SetKeyName(202, "sk.png")
        Me.CountryL.Images.SetKeyName(203, "sl.png")
        Me.CountryL.Images.SetKeyName(204, "sm.png")
        Me.CountryL.Images.SetKeyName(205, "sn.png")
        Me.CountryL.Images.SetKeyName(206, "so.png")
        Me.CountryL.Images.SetKeyName(207, "sr.png")
        Me.CountryL.Images.SetKeyName(208, "st.png")
        Me.CountryL.Images.SetKeyName(209, "sv.png")
        Me.CountryL.Images.SetKeyName(210, "sy.png")
        Me.CountryL.Images.SetKeyName(211, "sz.png")
        Me.CountryL.Images.SetKeyName(212, "tc.png")
        Me.CountryL.Images.SetKeyName(213, "td.png")
        Me.CountryL.Images.SetKeyName(214, "tg.png")
        Me.CountryL.Images.SetKeyName(215, "th.png")
        Me.CountryL.Images.SetKeyName(216, "tj.png")
        Me.CountryL.Images.SetKeyName(217, "tl.png")
        Me.CountryL.Images.SetKeyName(218, "tm.png")
        Me.CountryL.Images.SetKeyName(219, "tn.png")
        Me.CountryL.Images.SetKeyName(220, "to.png")
        Me.CountryL.Images.SetKeyName(221, "tr.png")
        Me.CountryL.Images.SetKeyName(222, "tt.png")
        Me.CountryL.Images.SetKeyName(223, "tv.png")
        Me.CountryL.Images.SetKeyName(224, "tw.png")
        Me.CountryL.Images.SetKeyName(225, "tz.png")
        Me.CountryL.Images.SetKeyName(226, "ua.png")
        Me.CountryL.Images.SetKeyName(227, "ug.png")
        Me.CountryL.Images.SetKeyName(228, "us.png")
        Me.CountryL.Images.SetKeyName(229, "uy.png")
        Me.CountryL.Images.SetKeyName(230, "uz.png")
        Me.CountryL.Images.SetKeyName(231, "va.png")
        Me.CountryL.Images.SetKeyName(232, "vc.png")
        Me.CountryL.Images.SetKeyName(233, "ve.png")
        Me.CountryL.Images.SetKeyName(234, "vg.png")
        Me.CountryL.Images.SetKeyName(235, "vi.png")
        Me.CountryL.Images.SetKeyName(236, "vn.png")
        Me.CountryL.Images.SetKeyName(237, "vu.png")
        Me.CountryL.Images.SetKeyName(238, "ws.png")
        Me.CountryL.Images.SetKeyName(239, "ye.png")
        Me.CountryL.Images.SetKeyName(240, "za.png")
        Me.CountryL.Images.SetKeyName(241, "zm.png")
        Me.CountryL.Images.SetKeyName(242, "zw.png")
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(112, 146)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(19, 19)
        Me.user.TabIndex = 21
        Me.user.Text = "--"
        Me.user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(80, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(54, 14)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X-SLAYER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 14)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "CODED BY : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.sbrank)
        Me.Panel1.Controls.Add(Me.videorank)
        Me.Panel1.Controls.Add(Me.subsrank)
        Me.Panel1.Controls.Add(Me.grade)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(3, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 71)
        Me.Panel1.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(19, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "TOTAL GRADE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(139, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 19)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "SUBSCRIBER RANK"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(284, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 19)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "VIDEO VIEW RANK"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(429, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 19)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "SOCIAL BLADE RANK "
        '
        'grade
        '
        Me.grade.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.grade.Location = New System.Drawing.Point(19, 10)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(105, 33)
        Me.grade.TabIndex = 13
        Me.grade.Text = "--"
        Me.grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subsrank
        '
        Me.subsrank.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subsrank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.subsrank.Location = New System.Drawing.Point(139, 10)
        Me.subsrank.Name = "subsrank"
        Me.subsrank.Size = New System.Drawing.Size(130, 33)
        Me.subsrank.TabIndex = 14
        Me.subsrank.Text = "--"
        Me.subsrank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'videorank
        '
        Me.videorank.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.videorank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.videorank.Location = New System.Drawing.Point(284, 10)
        Me.videorank.Name = "videorank"
        Me.videorank.Size = New System.Drawing.Size(130, 33)
        Me.videorank.TabIndex = 15
        Me.videorank.Text = "--"
        Me.videorank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sbrank
        '
        Me.sbrank.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbrank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sbrank.Location = New System.Drawing.Point(429, 10)
        Me.sbrank.Name = "sbrank"
        Me.sbrank.Size = New System.Drawing.Size(147, 33)
        Me.sbrank.TabIndex = 16
        Me.sbrank.Text = "--"
        Me.sbrank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 287)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.pcountry)
        Me.Controls.Add(Me.created)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.country)
        Me.Controls.Add(Me.count)
        Me.Controls.Add(Me.subs)
        Me.Controls.Add(Me.upload)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.photo)
        Me.Controls.Add(Me.cover)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Socialblade.com | BY X-SLAYER"
        CType(Me.cover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcountry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_ID As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cover As System.Windows.Forms.PictureBox
    Friend WithEvents photo As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents upload As System.Windows.Forms.Label
    Friend WithEvents subs As System.Windows.Forms.Label
    Friend WithEvents count As System.Windows.Forms.Label
    Friend WithEvents country As System.Windows.Forms.Label
    Friend WithEvents type As System.Windows.Forms.Label
    Friend WithEvents created As System.Windows.Forms.Label
    Friend WithEvents pcountry As System.Windows.Forms.PictureBox
    Friend WithEvents CountryL As System.Windows.Forms.ImageList
    Friend WithEvents user As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents grade As System.Windows.Forms.Label
    Friend WithEvents sbrank As System.Windows.Forms.Label
    Friend WithEvents videorank As System.Windows.Forms.Label
    Friend WithEvents subsrank As System.Windows.Forms.Label

End Class
