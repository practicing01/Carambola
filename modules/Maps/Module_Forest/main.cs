function Module_Forest::create(%this)
{

%this.Ass_Image_Grass=AssetDatabase.acquireAsset("Module_Forest:Image_Grass");

%this.Ass_Image_Grass_0=AssetDatabase.acquireAsset("Module_Forest:Image_Grass_0");

%this.Ass_Image_Log=AssetDatabase.acquireAsset("Module_Forest:Image_Log");

%this.Ass_Image_Rocks=AssetDatabase.acquireAsset("Module_Forest:Image_Rocks");

%this.Ass_Image_Rocks_0=AssetDatabase.acquireAsset("Module_Forest:Image_Rocks_0");

%this.Ass_Image_Rocks_1=AssetDatabase.acquireAsset("Module_Forest:Image_Rocks_1");

%this.Ass_Image_Rocks_2=AssetDatabase.acquireAsset("Module_Forest:Image_Rocks_2");

%this.Ass_Image_Shrub=AssetDatabase.acquireAsset("Module_Forest:Image_Shrub");

%this.Ass_Image_Shrub_0=AssetDatabase.acquireAsset("Module_Forest:Image_Shrub_0");

%this.Ass_Image_Shrub_1=AssetDatabase.acquireAsset("Module_Forest:Image_Shrub_1");

%this.Ass_Image_Shrub_2=AssetDatabase.acquireAsset("Module_Forest:Image_Shrub_2");

%this.Ass_Image_Shrub_3=AssetDatabase.acquireAsset("Module_Forest:Image_Shrub_3");

%this.Ass_Image_Shrub_4=AssetDatabase.acquireAsset("Module_Forest:Image_Shrub_4");

%this.Ass_Image_Stump=AssetDatabase.acquireAsset("Module_Forest:Image_Stump");

%this.Ass_Image_Tree=AssetDatabase.acquireAsset("Module_Forest:Image_Tree");

%this.Ass_Image_Tree_0=AssetDatabase.acquireAsset("Module_Forest:Image_Tree_0");

%this.Ass_Image_Tree_1=AssetDatabase.acquireAsset("Module_Forest:Image_Tree_1");

%this.Ass_Image_Vine_Long=AssetDatabase.acquireAsset("Module_Forest:Image_Vine_Long");

/**********************************************************************************/

%this.SimSet_String_Floor_Tiles=new SimSet();

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Grass";

};

%this.SimSet_String_Floor_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Grass_0";

};

%this.SimSet_String_Floor_Tiles.add(%ScriptObject_String_Floor_Tile);

/**********************************************************************************/

%this.SimSet_String_Floor_Detail_Tiles=new SimSet();

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Log";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Rocks";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Rocks_0";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Rocks_1";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Rocks_2";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Shrub";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Shrub_0";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Shrub_1";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Shrub_2";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Shrub_3";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Shrub_4";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/****************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Stump";

};

%this.SimSet_String_Floor_Detail_Tiles.add(%ScriptObject_String_Floor_Tile);

/**********************************************************************************/

//Towers:
//Static - Tree_0, Tree_1
//Slapper (Spinning) - Vine_Long
//Bumper - Tree
//Shooter (sensor)
//Corridor
//Directional Push
//Kinematic
//Instagib
//Hole
//AOE
//Trigger
//Scene Controller
//Shooter (non-sensor)
//Portal

/**********************************************************************************/

//Static

%this.SimSet_String_Static_Tower_Tiles=new SimSet();

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Tree_0";

Ass_Image=%this.Ass_Image_Tree_0;

};

%this.SimSet_String_Static_Tower_Tiles.add(%ScriptObject_String_Floor_Tile);

/**********************************************************************************/

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Tree_1";

Ass_Image=%this.Ass_Image_Tree_1;

};

%this.SimSet_String_Static_Tower_Tiles.add(%ScriptObject_String_Floor_Tile);

/**********************************************************************************/

//Slapper

%this.SimSet_String_Slapper_Tower_Tiles=new SimSet();

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Vine_Long";

Ass_Image=%this.Ass_Image_Vine_Long;

};

%this.SimSet_String_Slapper_Tower_Tiles.add(%ScriptObject_String_Floor_Tile);

/**********************************************************************************/

//Bumper

%this.SimSet_String_Bumper_Tower_Tiles=new SimSet();

%ScriptObject_String_Floor_Tile=new ScriptObject()
{

String_Name="Module_Forest:Image_Tree";

Ass_Image=%this.Ass_Image_Tree;

};

%this.SimSet_String_Bumper_Tower_Tiles.add(%ScriptObject_String_Floor_Tile);

/**********************************************************************************/

exec("./assets/Scripts/Scripts.cs");

%this.Bool_Casting_Tower=false;

%this.String_Casting_Tower_Type="";

%this.Int_Casting_Interval=8;

%this.Int_Casting_Interval_Counter=0;

%this.Int_Bumper_Tower_Max=25;

%this.Int_Bumper_Tower_Counter=0;

%this.Int_Slapper_Tower_Max=6;

%this.Int_Slapper_Tower_Counter=0;

%this.Int_Static_Tower_Max=50;

%this.Int_Static_Tower_Counter=0;

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Forest_Input_Controller";

Module_ID_Parent=%this;

};

Window_Carambola.addInputListener(%this.Script_Object_Input_Controller);

}

function Module_Forest::destroy(%this)
{

if (isObject(Window_Carambola)&&isObject(%this.Script_Object_Input_Controller))
{

Window_Carambola.removeInputListener(%this.Script_Object_Input_Controller);

}

%this.SimSet_String_Floor_Tiles.deleteObjects();

%this.SimSet_String_Floor_Tiles.delete();

%this.SimSet_String_Static_Tower_Tiles.deleteObjects();

%this.SimSet_String_Static_Tower_Tiles.delete();

%this.SimSet_String_Slapper_Tower_Tiles.deleteObjects();

%this.SimSet_String_Slapper_Tower_Tiles.delete();

%this.SimSet_String_Bumper_Tower_Tiles.deleteObjects();

%this.SimSet_String_Bumper_Tower_Tiles.delete();

AssetDatabase.releaseAsset(%this.Ass_Image_Grass.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Grass_0.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Log.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Rocks.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Rocks_0.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Rocks_1.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Shrub.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Shrub_0.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Shrub_1.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Shrub_2.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Shrub_3.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Shrub_4.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Stump.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Tree.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Tree_0.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Tree_1.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Vine_Long.getAssetId());

}

