using UnityEngine;

namespace BoundfoxStudios.CommunityProject.Weapons.Targeting
{
	/// <summary>
	/// The target point is _the point_ any weapon will aim at and shoot to.
	/// </summary>
	[AddComponentMenu(Constants.MenuNames.Targeting + "/" + nameof(TargetPoint))]
	[RequireComponent(typeof(SphereCollider))]
	public class TargetPoint : MonoBehaviour
	{
		private void Awake()
		{
			var sphereCollider = GetComponent<SphereCollider>();
			sphereCollider.isTrigger = true;
		}
	}
}
