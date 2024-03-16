import { useEffect } from 'react';
import Camille from '../assets/camille.jpg';
import Gwen from '../assets/gwen.jpeg';
import Video from '../assets/gwen_video.mp4';
import Lissandra from '../assets/lissandra.jpg';
import Warwick from '../assets/warwick.jpeg';
class Timeout {
  id;
  handler;
  start;
  timeLeft;
  constructor(handle: TimerHandler, time: number) {
    this.id = setTimeout(handle, time);
    this.handler = handle;
    this.start = Date.now();
    this.timeLeft = time;
  }
  clear() {
    clearTimeout(this.id);
  }
  pause() {
    const passed = Date.now() - this.start;
  }
}

class Slider {
  sliders;
  time;
  index;
  slide;
  paused: boolean;
  timeout: Timeout | null;
  pausedTimeout: Timeout | null;
  thumbItems: HTMLElement[] | null;
  thumb: HTMLElement | null;

  constructor(slides: Element[], time: number = 5000) {
    this.sliders = slides;
    this.time = time;
    this.index = 0;
    this.slide = this.sliders[this.index];
    this.paused = false;
    this.timeout = null;
    this.pausedTimeout = null;
    this.thumbItems = null;
    this.thumb = null;

    this.init();
  }
  hide(el: Element) {
    el.classList.remove('active');
    if (el instanceof HTMLVideoElement) {
      el.currentTime = 0;
      el.pause();
    }
  }
  show(index: number) {
    this.index = index;
    this.slide = this.sliders[this.index];
    this.sliders.forEach((el) => this.hide(el));
    if (this.thumbItems) {
      this.thumb = this.thumbItems[this.index];
      this.thumbItems.forEach((el) => el.classList.remove('active'));
      this.thumb.classList.add('active');
    }
    this.slide.classList.add('active');
    this.auto(this.time);
    if (this.slide instanceof HTMLVideoElement) {
      this.autoVideo(this.slide);
    } else {
      this.auto(this.time);
    }
  }
  autoVideo(video: HTMLVideoElement) {
    video.muted = true;
    video.play();
    let firstPlay = true;
    video.addEventListener('playing', () => {
      if (firstPlay) this.auto(video.duration * 1000);
      firstPlay = false;
    });
  }
  auto(time: number) {
    this.timeout?.clear();
    this.timeout = new Timeout(() => this.next(), time);
    if (this.thumb) this.thumb.style.animationDuration = `${time}ms`;
  }
  next() {
    if (this.paused) return;
    const next = this.index + 1 < this.sliders.length ? this.index + 1 : 0;
    this.show(next);
  }

  private init() {
    this.show(this.index);
  }
}

const Slide = () => {
  useEffect(() => {
    const elements = document.querySelector('.slide');
    elements && new Slider(Array.from(elements.children), 3000);
  }, []);
  return (
    <div className="slide">
      <img src={Lissandra} alt="" />
      <img src={Gwen} alt="" className="gwen" />
      <img src={Camille} alt="" />
      <img src={Warwick} alt="" />
      <video src={Video}></video>
    </div>
  );
};

export default Slide;
