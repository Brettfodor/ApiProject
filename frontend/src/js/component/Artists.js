
export default function Artists(artists) {
    return `
    <div class='objectGrid'>
            ${artists
              .map(artist => {
                return `
                    <div class='objectItem'>
                        <h3>${artist.name}</h3>
                        <img class="artist__image" src=${artist.image}></img>
                        <input class="artist__id" type="hidden" value="${artist.id}">
                        <button class="edit-artist__submit" >Edit</button>
                        <button class="delete-artist__submit">Delete</button>
                    </div>
                `;
              })
              .join("")}
         </div>
        
         <section class='add-artist'>
            <input class='add-artist__artistname' type='text' placeholder='Add an artist!'>
            <input class='add-artist__artistimg' type='hidden' value='./css/images/genericArtist.jpg'>
            <button class='add-artist__submit'>Submit</button>
        </section>
  
    `
}