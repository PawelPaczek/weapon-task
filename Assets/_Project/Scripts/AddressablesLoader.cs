using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressablesLoader : MonoBehaviour
{
    public async Task<Sprite> GetIconAssetAsync(string assetAddress)
    {
        AsyncOperationHandle<Texture2D> handle = Addressables.LoadAssetAsync<Texture2D>(assetAddress);

        await handle.Task;

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            Texture2D  loadedTexture = handle.Result;
            Sprite loadedSprite = Sprite.Create(loadedTexture, new Rect(0, 0, loadedTexture.width, loadedTexture.height), Vector2.zero);

            Addressables.Release(handle);
            return loadedSprite;
        }
        else
        {
            Debug.LogError("Failed to load!");
            return null;
        }
    }
}