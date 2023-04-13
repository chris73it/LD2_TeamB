//Maya ASCII 2023 scene
//Name: mimic.ma
//Last modified: Thu, Mar 23, 2023 11:47:01 AM
//Codeset: 1252
requires maya "2023";
requires "stereoCamera" "10.0";
requires "mtoa" "5.1.2";
requires "mtoa" "5.1.2";
requires "stereoCamera" "10.0";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2023";
fileInfo "version" "2023";
fileInfo "cutIdentifier" "202208031415-1dee56799d";
fileInfo "osv" "Windows 10 Enterprise LTSC 2021 v2009 (Build: 19044)";
fileInfo "UUID" "7D224B9D-403E-AA3F-4365-3AB520F86495";
fileInfo "license" "education";
createNode clipLibrary -n "clipLibrary1";
	rename -uid "AE0495B4-4D77-F889-CE82-2BB68798AD24";
	setAttr -s 10 ".cel[0].cev";
	setAttr ".cd[0].cm" -type "characterMapping" 10 "joint1.scaleZ" 0 1 "joint1.scaleY" 
		0 2 "joint1.scaleX" 0 3 "joint1.translateZ" 1 1 "joint1.translateY" 
		1 2 "joint1.translateX" 1 3 "joint1.visibility" 0 4 "joint1.rotateZ" 
		2 1 "joint1.rotateY" 2 2 "joint1.rotateX" 2 3  ;
	setAttr ".cd[0].cim" -type "Int32Array" 10 0 1 2 3 4
		 5 6 7 8 9 ;
createNode animClip -n "clip1Source";
	rename -uid "41A0EBCF-406C-980B-1C09-C2947DAA056C";
	setAttr ".ihi" 0;
	setAttr -s 10 ".ac[0:9]" yes yes yes yes yes yes yes yes yes yes;
	setAttr ".ss" 1;
	setAttr ".se" 58;
	setAttr ".ci" no;
createNode animCurveTU -n "joint1_scaleZ";
	rename -uid "D1E9E1B5-4163-A5BF-E2E2-EAB4A6601C1C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 1 10 1 20 1 29 1 39 1 48 1 58 1;
createNode animCurveTU -n "joint1_scaleY";
	rename -uid "746BA2DD-4658-8F1B-6B3E-9C80F30FFDCF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 1 10 1 20 1 29 1 39 1 48 1 58 1;
createNode animCurveTU -n "joint1_scaleX";
	rename -uid "DB6F0A9E-4E5F-6ED1-B1F3-228FC2C9791C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 1 10 1 20 1 29 1 39 1 48 1 58 1;
createNode animCurveTL -n "joint1_translateZ";
	rename -uid "C457FFAF-45A1-D2DC-944E-CBA26B31A959";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 -0.53439627314386662 10 -0.53439627314386662
		 20 -0.53439627314386662 29 -0.53439627314386662 39 -0.53439627314386662 48 -0.53439627314386662
		 58 -0.53439627314386662;
createNode animCurveTL -n "joint1_translateY";
	rename -uid "C7836504-4F68-046D-4092-01B576003344";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 7.2515187539853239 10 7.2515187539853239
		 20 7.2515187539853239 29 7.2515187539853239 39 7.2515187539853239 48 7.2515187539853239
		 58 7.2515187539853239;
createNode animCurveTL -n "joint1_translateX";
	rename -uid "DEC5A10A-4D23-D037-023F-9E9A3A4EA57F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 -7.9098952344225859 10 -7.9098952344225859
		 20 -7.9098952344225859 29 -7.9098952344225859 39 -7.9098952344225859 48 -7.9098952344225859
		 58 -7.9098952344225859;
createNode animCurveTU -n "joint1_visibility";
	rename -uid "CD210A16-4393-9A7A-1162-DBB383F01D23";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 1 10 1 20 1 29 1 39 1 48 1 58 1;
	setAttr -s 7 ".kot[0:6]"  5 5 5 5 5 5 5;
createNode animCurveTA -n "joint1_rotateZ";
	rename -uid "950FA770-409F-D2FF-3F0D-DE8570DFAE99";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 -18.15974755619386 10 -32.597908028887282
		 20 -18.15974755619386 29 -32.597908028887282 39 -18.15974755619386 48 -32.597908028887282
		 58 -19.427686968902034;
createNode animCurveTA -n "joint1_rotateY";
	rename -uid "09589B55-4CBF-BD09-D982-13BD986808DC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 0 10 0 20 0 29 0 39 0 48 0 58 0;
createNode animCurveTA -n "joint1_rotateX";
	rename -uid "984B2CB7-40FF-D074-92A6-729CEEABB4E5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 0 10 0 20 0 29 0 39 0 48 0 58 0;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 5 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr -s 3 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 2 ".gn";
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	addAttr -ci true -h true -sn "dss" -ln "defaultSurfaceShader" -dt "string";
	setAttr ".ren" -type "string" "arnold";
	setAttr ".dss" -type "string" "lambert1";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :defaultColorMgtGlobals;
	setAttr ".cfe" yes;
	setAttr ".cfp" -type "string" "<MAYA_RESOURCES>/OCIO-configs/Maya2022-default/config.ocio";
	setAttr ".vtn" -type "string" "ACES 1.0 SDR-video (sRGB)";
	setAttr ".vn" -type "string" "ACES 1.0 SDR-video";
	setAttr ".dn" -type "string" "sRGB";
	setAttr ".wsn" -type "string" "ACEScg";
	setAttr ".otn" -type "string" "ACES 1.0 SDR-video (sRGB)";
	setAttr ".potn" -type "string" "ACES 1.0 SDR-video (sRGB)";
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :characterPartition;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "clip1Source.cl" "clipLibrary1.sc[0]";
connectAttr "joint1_scaleZ.a" "clipLibrary1.cel[0].cev[0].cevr";
connectAttr "joint1_scaleY.a" "clipLibrary1.cel[0].cev[1].cevr";
connectAttr "joint1_scaleX.a" "clipLibrary1.cel[0].cev[2].cevr";
connectAttr "joint1_translateZ.a" "clipLibrary1.cel[0].cev[3].cevr";
connectAttr "joint1_translateY.a" "clipLibrary1.cel[0].cev[4].cevr";
connectAttr "joint1_translateX.a" "clipLibrary1.cel[0].cev[5].cevr";
connectAttr "joint1_visibility.a" "clipLibrary1.cel[0].cev[6].cevr";
connectAttr "joint1_rotateZ.a" "clipLibrary1.cel[0].cev[7].cevr";
connectAttr "joint1_rotateY.a" "clipLibrary1.cel[0].cev[8].cevr";
connectAttr "joint1_rotateX.a" "clipLibrary1.cel[0].cev[9].cevr";
// End of mimic.ma
