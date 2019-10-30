import AlbumList from "./component/albumList";

export default function ArtistProfile() {
    
    let returnHtml = "";
    returnHtml+=`
    <h1>Artist Name</h1>
    <img href='Artist Image'></img>
    `
    returnHtml+= albumList();
    return returnHtml;
};
function albumList(){
    const albumList = document.getElementById("album-list");
    albumList.innerHTML = AlbumList();
}