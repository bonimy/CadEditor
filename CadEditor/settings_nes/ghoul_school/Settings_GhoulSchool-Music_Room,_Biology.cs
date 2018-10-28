using CadEditor;
using System;
using System.Drawing;

public class Data 
{ 
  public OffsetRec getScreensOffset() { return new OffsetRec(0x14246, 1, 12*96, 12, 96); }
  public bool getScreenVertical()      { return true; }

  public bool isBigBlockEditorEnabled() { return false; }
  public bool isBlockEditorEnabled()    { return true; }
  public bool isEnemyEditorEnabled()    { return false; }
  
  public GetVideoPageAddrFunc getVideoPageAddrFunc() { return getVideoAddress; }
  public GetVideoChunkFunc    getVideoChunkFunc()    { return getVideoChunk;   }
  public SetVideoChunkFunc    setVideoChunkFunc()    { return null; }
  
  public bool isBuildScreenFromSmallBlocks() { return true; }
  
  public OffsetRec getBlocksOffset()    { return new OffsetRec(0x14011, 1  , 0x1000);  }
  public int getBlocksCount()           { return 109; }
  public int getBigBlocksCount()        { return 109; }
  public int getPalBytesAddr()          { return 0x141c5; }
  
  public GetBlocksFunc        getBlocksFunc() { return getBlocks;}
  public SetBlocksFunc        setBlocksFunc() { return setBlocks;}
  public GetPalFunc           getPalFunc()           { return getPallete;}
  public SetPalFunc           setPalFunc()           { return null;}
  
  //----------------------------------------------------------------------------
  public ObjRec[] getBlocks(int tileId)
  {
    return Utils.readBlocksFromAlignedArrays(Globals.romdata, ConfigScript.getTilesAddr(tileId), ConfigScript.getBlocksCount(tileId), false);
  }
  
  public void setBlocks(int tileId, ObjRec[] blocks)
  {
    Utils.writeBlocksToAlignedArrays(blocks, Globals.romdata, ConfigScript.getTilesAddr(tileId), ConfigScript.getBlocksCount(tileId), true, false);
  }
  
  public byte[] getPallete(int palId)
  {
      return Utils.readBinFile("pal-musicroom.bin");
  }
  
  public int getVideoAddress(int id)
  {
    return -1;
  }
  
  public byte[] getVideoChunk(int videoPageId)
  {
     return Utils.readVideoBankFromFile("chr-musicroom.bin", videoPageId);
  }
}