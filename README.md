# Skinned Mesh To Collider Tool

<p align="center">
  <img src="https://img.shields.io/badge/Unity-2020.3%2B-blue" alt="Unity Version">
  <img src="https://img.shields.io/badge/License-MIT-green" alt="License">
  <img src="https://img.shields.io/badge/Metin2-Map%20Tools-orange" alt="Metin2 Map Tools">
</p>

## Overview

The **Skinned Mesh To Collider Tool** is a specialized Unity Editor utility designed to streamline the process of adding collision detection to skinned mesh renderers in Unity scenes. Developed by Metin2Avi, this tool addresses a common challenge in game development: creating accurate collision detection for animated and skinned meshes.

## Purpose

In Unity, skinned meshes (used for animated characters and objects) don't automatically come with appropriate collision detection. Manually creating colliders for these meshes can be time-consuming and error-prone. This tool automates the process by:

1. Finding all GameObjects with SkinnedMeshRenderer components in the current scene
2. Creating or updating MeshCollider components on these objects
3. Baking the current state of the skinned mesh into the collider mesh

## Features

- **One-Click Operation**: Add mesh colliders to all skinned meshes in the scene with a single button press
- **Smart Detection**: Automatically identifies all objects with SkinnedMeshRenderer components
- **Intelligent Handling**: Updates existing colliders instead of creating duplicates
- **Progress Feedback**: Detailed console logs and completion dialog
- **Undo Support**: Uses Unity's Undo system for non-destructive operations
- **User-Friendly Interface**: Simple, clean editor window with social media links

## Technical Implementation

The tool works by:
1. Using `FindObjectsOfType<SkinnedMeshRenderer>()` to locate all skinned meshes in the scene
2. For each mesh:
   - Checking if it already has a MeshCollider component
   - Creating a new MeshCollider if needed
   - Baking the current state of the skinned mesh into a new Mesh object
   - Assigning this baked mesh to the collider's `sharedMesh` property
3. Providing feedback via the Unity console and dialog boxes

## Installation

1. Import the script into your Unity project
2. Place it in an Editor folder to ensure it's compiled correctly
3. Access the tool through the Unity menu: `Tools > Skinned Mesh To Collider Tool - @Metin2Avi`

## Usage Instructions

1. Open your Unity scene containing skinned meshes
2. Select `Tools > Skinned Mesh To Collider Tool - @Metin2Avi` from the menu
3. In the window that appears, click the "Add Mesh Colliders" button
4. Wait for the process to complete
5. A dialog will show how many objects were processed

## Best Practices and Considerations

- **Performance Impact**: Mesh colliders are more CPU-intensive than primitive colliders. Use this tool wisely for important collision detection needs.
- **Mesh Complexity**: The generated colliders will match the complexity of your skinned meshes. For better performance, consider using simplified collision meshes for complex characters.
- **Animation States**: The collider will be based on the current pose of the skinned mesh. Ensure your character is in an appropriate pose before applying.
- **Dynamic Updates**: The colliders created are static. For continuously updating colliders on animated meshes, additional runtime scripts would be needed.

## Benefits

- **Time Savings**: Eliminates the need to manually add colliders to each skinned mesh
- **Consistency**: Ensures all skinned meshes have proper collision detection
- **Easy Integration**: Works seamlessly with existing Unity projects
- **Quality Improvement**: Helps prevent collision detection issues in game development

## Contact Information

- Instagram: [@metin2.avi](https://www.instagram.com/metin2.avi/)
- Discord: [Join Server](https://discord.gg/WZMzMgPp38)
- YouTube: [@project_avi](https://www.youtube.com/@project_avi)
- Metin2Downloads: [Profile](https://www.metin2downloads.to/cms/user/30621-metin2avi/)
- M2Dev: [Profile](https://metin2.dev/profile/53064-metin2avi/)
- Turkmmo: [Profile](https://forum.turkmmo.com/uye/165187-trmove/)

---

# Skinned Mesh'ten Çarpışma Alanı Oluşturma Aracı

## Genel Bakış

**Skinned Mesh To Collider Tool**, Unity sahnelerindeki skinned mesh renderer'lara çarpışma algılama özelliği ekleme sürecini kolaylaştırmak için tasarlanmış özel bir Unity Editor aracıdır. Metin2Avi tarafından geliştirilen bu araç, oyun geliştirmede yaygın bir zorluğu ele alır: Animasyonlu ve skinned mesh'ler için doğru çarpışma algılama sistemi oluşturma.

## Amaç

Unity'de, skinned mesh'ler (animasyonlu karakterler ve nesneler için kullanılır) otomatik olarak uygun çarpışma algılama özelliğine sahip değildir. Bu mesh'ler için manuel olarak çarpıştırıcı oluşturmak zaman alıcı ve hata yapmaya müsait bir süreçtir. Bu araç süreci şu şekilde otomatikleştirir:

1. Mevcut sahnedeki SkinnedMeshRenderer bileşenine sahip tüm GameObject'leri bulur
2. Bu nesnelere MeshCollider bileşenleri oluşturur veya günceller
3. Skinned mesh'in mevcut durumunu çarpıştırıcı mesh'ine aktarır

## Özellikler

- **Tek Tıklama İşlemi**: Tek bir düğme basışıyla sahnedeki tüm skinned mesh'lere mesh çarpıştırıcıları ekler
- **Akıllı Algılama**: SkinnedMeshRenderer bileşenlerine sahip tüm nesneleri otomatik olarak tanımlar
- **Akıllı İşleme**: Yinelenen öğeler oluşturmak yerine mevcut çarpıştırıcıları günceller
- **İlerleme Geri Bildirimi**: Ayrıntılı konsol kayıtları ve tamamlanma iletişim kutusu sunar
- **Geri Alma Desteği**: Yıkıcı olmayan işlemler için Unity'nin Geri Alma sistemini kullanır
- **Kullanıcı Dostu Arayüz**: Sosyal medya bağlantıları içeren basit, temiz bir editör penceresi

## Teknik Uygulama

Araç şu şekilde çalışır:
1. Sahnedeki tüm skinned mesh'leri bulmak için `FindObjectsOfType<SkinnedMeshRenderer>()` kullanır
2. Her mesh için:
   - Halihazırda bir MeshCollider bileşenine sahip olup olmadığını kontrol eder
   - Gerekirse yeni bir MeshCollider oluşturur
   - Skinned mesh'in mevcut durumunu yeni bir Mesh nesnesine aktarır
   - Bu aktarılmış mesh'i çarpıştırıcının `sharedMesh` özelliğine atar
3. Unity konsolu ve iletişim kutuları aracılığıyla geri bildirim sağlar

## Kurulum

1. Komut dosyasını Unity projenize aktarın
2. Doğru şekilde derlenmesini sağlamak için bir Editor klasörüne yerleştirin
3. Araca Unity menüsünden erişin: `Tools > Skinned Mesh To Collider Tool - @Metin2Avi`

## Kullanım Talimatları

1. Skinned mesh'ler içeren Unity sahnenizi açın
2. Menüden `Tools > Skinned Mesh To Collider Tool - @Metin2Avi` seçeneğini seçin
3. Açılan pencerede "Add Mesh Colliders" düğmesine tıklayın
4. İşlemin tamamlanmasını bekleyin
5. Bir iletişim kutusu kaç nesnenin işlendiğini gösterecektir

## En İyi Uygulamalar ve Dikkat Edilecek Hususlar

- **Performans Etkisi**: Mesh çarpıştırıcılar, ilkel çarpıştırıcılardan daha CPU yoğundur. Bu aracı önemli çarpışma algılama ihtiyaçları için akıllıca kullanın.
- **Mesh Karmaşıklığı**: Oluşturulan çarpıştırıcılar, skinned mesh'lerinizin karmaşıklığıyla eşleşecektir. Daha iyi performans için, karmaşık karakterler için basitleştirilmiş çarpışma mesh'leri kullanmayı düşünün.
- **Animasyon Durumları**: Çarpıştırıcı, skinned mesh'in mevcut duruşuna göre oluşturulacaktır. Uygulamadan önce karakterinizin uygun bir duruşta olduğundan emin olun.
- **Dinamik Güncellemeler**: Oluşturulan çarpıştırıcılar statiktir. Animasyonlu mesh'lerde sürekli güncellenen çarpıştırıcılar için ek çalışma zamanı komut dosyaları gereklidir.

## Faydalar

- **Zaman Tasarrufu**: Her skinned mesh'e manuel olarak çarpıştırıcı ekleme ihtiyacını ortadan kaldırır
- **Tutarlılık**: Tüm skinned mesh'lerin uygun çarpışma algılamasına sahip olmasını sağlar
- **Kolay Entegrasyon**: Mevcut Unity projeleriyle sorunsuz çalışır
- **Kalite İyileştirmesi**: Oyun geliştirmede çarpışma algılama sorunlarını önlemeye yardımcı olur

## İletişim Bilgileri

- Instagram: [@metin2.avi](https://www.instagram.com/metin2.avi/)
- Discord: [Sunucuya Katıl](https://discord.gg/WZMzMgPp38)
- YouTube: [@project_avi](https://www.youtube.com/@project_avi)
- Metin2Downloads: [Profil](https://www.metin2downloads.to/cms/user/30621-metin2avi/)
- M2Dev: [Profil](https://metin2.dev/profile/53064-metin2avi/)
- Turkmmo: [Profil](https://forum.turkmmo.com/uye/165187-trmove/)
