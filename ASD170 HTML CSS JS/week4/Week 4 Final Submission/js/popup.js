/* Borrowed basic JS Modal template from WebDevSimplified       */
/* https://github.com/WebDevSimplified/Vanilla-JavaScript-Modal */

"use strict";

// var onMobile = false;

// window.addEventListener("resize", () => {
//   if (screen.width >= 800) {
//     onMobile = false;
//   } else onMobile = true;
// });


var width =
  window.innerWidth ||
  document.documentElement.clientWidth ||
  document.body.clientWidth;

if (
  /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)
  || width < 800
  ) {
      
} else {
  const openModalButtons = document.querySelectorAll("[data-modal-target]");
  const closeModalButtons = document.querySelectorAll("[data-close-button]");
  const overlay = document.getElementById("overlay");

  openModalButtons.forEach(button => {
    button.addEventListener("click", () => {
      const modal = document.querySelector(button.dataset.modalTarget);
      var title = button.getElementsByClassName("beer-title")[0].textContent;
      var style = button.getElementsByClassName("beer-style")[0].textContent;
      var description = button.getElementsByClassName("beer-description")[0]
        .textContent;
      var img = button.getElementsByTagName("img")[0].outerHTML;
      document
        .getElementById("modal")
        .getElementsByClassName("beerTitle")[0].textContent = title;
      document
        .getElementById("modal")
        .getElementsByClassName("beerStyle")[0].textContent = style;
      document
        .getElementById("modal")
        .getElementsByClassName("modal-body")[0].textContent = description;
      document
        .getElementById("modal")
        .getElementsByClassName("modal-body")[0]
        .insertAdjacentHTML("afterbegin", img);
      openModal(modal);
    });
  });

  overlay.addEventListener("click", () => {
    const modals = document.querySelectorAll(".modal.active");
    modals.forEach(modal => {
      closeModal(modal);
    });
  });

  closeModalButtons.forEach(button => {
    button.addEventListener("click", () => {
      const modal = button.closest(".modal");
      closeModal(modal);
    });
  });

  function openModal(modal) {
    if (modal == null) return;
    modal.classList.add("active");
    overlay.classList.add("active");
  }

  function closeModal(modal) {
    if (modal == null) return;
    modal.classList.remove("active");
    overlay.classList.remove("active");
  }
}
